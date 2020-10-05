using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TPJPlayer
{
    public class Compression : Effect
    {
        public bool enabled = true;
        public int factor;
        public float current_right;
        public float current_left;
        int count;
        public Compression()
        {
            this.count = 0;
            this.factor = 2;
            this.current_right = 1f;
            this.current_left = -1f;
        }

        public override float ApplyEffect(float sample)
        {
            if (enabled)
            {
                if(count == 0 || count >= factor)
                {
                    count = 0;
                    if(sample >= 0)
                    {
                        current_right = sample;
                        current_left = -sample;
                    }
                    else
                    {
                        current_right = -sample;
                        current_left = sample;
                    }
                }
                count++;
                if(sample >= 0)
                {
                    return current_right;
                }
                else
                {
                    return current_left;
                }
            }
            else
            {
                return sample;
            }
        }

        public void Update(int f)
        {
            this.factor = f*f;
            current_left = 0;
            current_right = 0;
        }
    }
}
