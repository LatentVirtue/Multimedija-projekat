﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.IO;
using System.Windows.Forms;


namespace TPJPlayer
{
    class Player
    {
        public BlockAlignReductionStream stream = null;
        public string Name = "";
        public DirectSoundOut output = null;
        public EffectStream effect = null;

        public Player()
        {
        }
        public bool open()
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Audio File (*.mp3;*.wav)|*.mp3;*.wav;";
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
            for (int i = 0; i < stream.WaveFormat.Channels; i++)
            {
                effect.Effects[i].Add(new Echo());
                effect.Effects[i].Add(new Panning());
                effect.Effects[i].Add(new Distorsion());
                effect.Effects[i].Add(new CustomEffect1());
                effect.Effects[i].Add(new CustomEffect2());
                effect.Effects[i].Add(new CustomEffect3());
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
