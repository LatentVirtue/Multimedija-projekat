using System;
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
        private static int count = 0;
        private int id;
        public Panning()
        {
            id = count;
            count++;
        }
        public void Update(float pf)
        {
            PanFactor = pf;
        }
        public override float ApplyEffect(float sample)
        {
            if (enabled)
            {
                if (PanFactor < 0)
                {
                    if (this.id < count / 2)
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
                    if (this.id >= count / 2)
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
