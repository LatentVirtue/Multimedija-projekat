using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPJPlayer
{
    public class Distorsion : Effect
    {
        public bool enabled = true;
        float a;
        public Distorsion(float a = 0)
        {
            this.a = a;
        }
        public override float ApplyEffect(float sample)
        {
            if (enabled)
            {
                if (sample >= 0)
                {
                    return Math.Min(1, sample + a);
                }
                else
                {
                    return Math.Max(-1, sample - a);
                }
            }
            else
            {
                return sample;
            }
        }
        public void Update(float a)
        {
            this.a = a;
        }
    }
}
