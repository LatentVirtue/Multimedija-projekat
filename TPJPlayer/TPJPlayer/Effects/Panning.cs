﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPJPlayer
{
    public class Panning : Effect
    {
        public bool enabled = true;
        public static float PanFactor = 0;
        private bool left;
        public Panning(int channel)
        {
            left = channel == 0;
        }
        public void Update(float f)
        {
            PanFactor = f;
        }
        public override float ApplyEffect(float sample)
        {
            if (enabled)
            {
                if (PanFactor < 0)
                {
                    if (left)
                    {
                        return Math.Min(1, Math.Max(-1, sample + sample * Math.Abs(PanFactor)));
                    }
                    else
                    {
                        return Math.Min(1, Math.Max(-1, sample - sample * Math.Abs(PanFactor)));
                    }
                }
                else if (PanFactor == 0)
                {
                    return sample;
                }
                else
                {
                    if (!left)
                    {
                        return Math.Min(1, Math.Max(-1, sample + sample * Math.Abs(PanFactor)));
                    }
                    else
                    {
                        return Math.Min(1, Math.Max(-1, sample - sample * Math.Abs(PanFactor)));
                    }
                }
            }
            else
            {
                return sample;
            }
        }
    }
}
