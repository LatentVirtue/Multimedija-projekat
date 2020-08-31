using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace TPJPlayer
{
    public class EffectStream : WaveStream
    {
        public override WaveFormat WaveFormat
        {
            get;
        }
        public WaveStream SourceStream
        {
            get;
            set;
        }
        public List<List<Effect>> Effects
        {
            get;
            private set;
        }
        public EffectStream(WaveStream stream)
        {
            SourceStream = stream;
            Effects = new List<List<Effect>>();
            WaveFormat = stream.WaveFormat;
            for(int i = 0; i < WaveFormat.Channels; i++)
            {
                Effects.Add(new List<Effect>());
            }
        }
        public override long Length
        {
            get
            {
                return SourceStream.Length;
            }
        }
        public override long Position
        {
            get
            {
                return SourceStream.Position;
            }
            set
            {
                SourceStream.Position = value;
            }
        }
        private int channel = 0;
        public override int Read(byte[] buffer, int offset, int count)
        {
            int read = SourceStream.Read(buffer, offset, count);
            for (int i = 0; i < read / 4; i++)
            {
                float sample = BitConverter.ToSingle(buffer, i * 4);
                if (Effects.Count == WaveFormat.Channels)
                {
                    foreach(Effect e in Effects[channel])
                    {
                        sample = e.ApplyEffect(sample);
                    }
                    channel = (channel + 1) % WaveFormat.Channels;
                }
                byte[] bytes = BitConverter.GetBytes(sample);
                buffer[i * 4 + 0] = bytes[0];
                buffer[i * 4 + 1] = bytes[1];
                buffer[i * 4 + 2] = bytes[2];
                buffer[i * 4 + 3] = bytes[3];
            }
            return read;
        }
    }
}
