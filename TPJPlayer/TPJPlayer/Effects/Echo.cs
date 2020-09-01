using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPJPlayer
{
    public class Echo : Effect
    {
        public bool enabled = true;
        public int EchoLength;
        public float EchoFactor;
        private Queue<float> samples;
        public Echo(int length = 20000, float factor = 1.0f)
        {
            this.EchoLength = length;
            this.EchoFactor = factor;
            this.samples = new Queue<float>();
            for (int i = 0; i < length; i++)
            {
                samples.Enqueue(0f);
            }
        }
        public override float ApplyEffect(float sample)
        {
            if (enabled)
            {
                float en = sample + EchoFactor * 0.1f * samples.Dequeue();
                samples.Enqueue(en);
                return Math.Min(1, Math.Max(-1, en));
            }
            else
            {
                return sample;
            }
        }
        public void Update()
        {
            if (EchoLength > samples.Count)
            {
                for (int i = 0; i < EchoLength - samples.Count; i++)
                {
                    samples.Enqueue(0f);
                }
            }
            else if (samples.Count > EchoLength)
            {
                for (int i = 0; i < samples.Count - EchoLength; i++)
                {
                    samples.Dequeue();
                }
            }
        }
    }
}
