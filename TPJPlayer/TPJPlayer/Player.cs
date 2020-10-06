using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.IO;
using System.Windows.Forms;
using System.Windows.Input;

namespace TPJPlayer
{
    class Player
    {
        public Equalizer equalizer;
        public BlockAlignReductionStream stream = null;
        public string Name = "";
        public DirectSoundOut output = null;
        public EffectStream effect = null;
        private readonly EqualizerBand[] bands;

        public Player() 
        {
            bands = new EqualizerBand[]
                    {
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 100, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 200, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 400, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 800, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 1200, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 2400, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 4800, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 9600, Gain = 0},
                    };
        }

        public float MinimumGain => -30;

        public float MaximumGain => 30;

        public float Band1
        {
            get => bands[0].Gain;
            set
            {
                if (bands[0].Gain != value)
                {
                    bands[0].Gain = value;
                }
            }
        }

        public float Band2
        {
            get => bands[1].Gain;
            set
            {
                if (bands[1].Gain != value)
                {
                    bands[1].Gain = value;
                }
            }
        }

        public float Band3
        {
            get => bands[2].Gain;
            set
            {
                if (bands[2].Gain != value)
                {
                    bands[2].Gain = value;
                }
            }
        }

        public float Band4
        {
            get => bands[3].Gain;
            set
            {
                if (bands[3].Gain != value)
                {
                    bands[3].Gain = value;
                }
            }
        }

        public float Band5
        {
            get => bands[4].Gain;
            set
            {
                if (bands[4].Gain != value)
                {
                    bands[4].Gain = value;
                }
            }
        }

        public float Band6
        {
            get => bands[5].Gain;
            set
            {
                if (bands[5].Gain != value)
                {
                    bands[5].Gain = value;
                }
            }
        }


        public float Band7
        {
            get => bands[6].Gain;
            set
            {
                if (bands[6].Gain != value)
                {
                    bands[6].Gain = value;
                }
            }
        }

        public float Band8
        {
            get => bands[7].Gain;
            set
            {
                if (bands[7].Gain != value)
                {
                    bands[7].Gain = value;
                }
            }
        }
        public bool open()
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Audio File (*.mp3;*.wav;*.flac)|*.mp3;*.wav;*.flac;";
            if (d.ShowDialog() != DialogResult.OK)
            {
                return false;
            }
            WaveStream t;
            Dispose();
            this.Name = d.SafeFileName;
            t = new WaveChannel32(new AudioFileReader(d.FileName));
            effect = new EffectStream(t);
            stream = new BlockAlignReductionStream(effect);
            equalizer = new Equalizer(stream.ToSampleProvider(), bands);
            for (int i = 0; i < equalizer.WaveFormat.Channels; i++)
            {
                effect.Effects[i].Add(new Echo());
                effect.Effects[i].Add(new Panning());
                effect.Effects[i].Add(new Distorsion());
                effect.Effects[i].Add(new Compression());
            }
            return true;
        }
        public bool play()
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing)
                {
                    output.Pause();
                    return false;
                }
                else if (output.PlaybackState == PlaybackState.Paused)
                {
                    output.Play();
                    return true;
                }
            }
            else
            {
                output = new DirectSoundOut();
                output.Init(stream);
                output.Init(equalizer);
                output.Play();
                return true;
            }
            return false;
        }
        public bool stop()
        {
            output.Stop();
            return true;
        }
        public void Dispose()
        {
            if(equalizer != null)
            {
                equalizer.Dispose();
                equalizer = null;
            }
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing)
                {
                    output.Stop();
                }
                output.Dispose();
                output = null;
            }
            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
        }
    }
    
}
