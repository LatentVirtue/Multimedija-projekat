using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
//svaka klasa poseban fajl
//
//funkcija normalize sa static
//using static za ^^^

//reverb 
namespace TPJPlayer
{
    public interface IEffect
    {
        float ApplyEffect(float sample);
    }
    public abstract class Effect : IEffect
    {
        public abstract float ApplyEffect(float sample);

    }
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
                samples.Enqueue(sample);
                return Math.Min(1, Math.Max(-1, sample + EchoFactor * samples.Dequeue()));
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

    public class CustomEffect1 : Effect
    {
        public bool enabled = true;
        private float a;
        private int count = 0;
        public long range;
        public CustomEffect1(float a = -1, long range = 0)
        {
            this.a = a;
            this.range = range;
        }
        public void Update(int range)
        {
            this.range = range;
        }
        public override float ApplyEffect(float sample)
        {
            if (count % (range + 1) == 0)
            {
                a = sample;
            }
            a = (a + Math.Abs(sample) / (range / 20));
            if (a == 1)
            {
                a = sample;
            }
            count++;
            if (enabled)
            {
                if (range != 0)
                {
                    return Math.Min(1, a + sample);
                }
                else
                {
                    return sample;
                }
            }
            else
            {
                return sample;
            }
        }
    }
    public class CustomEffect2 : Effect
    {
        public bool enabled = true;
        private float a;
        float temp = 0f;
        int count = 0;

        public CustomEffect2(float a = 0)
        {
            this.a = a;
        }

        public void Update(float a)
        {
            this.a = a * 5;
        }
        public override float ApplyEffect(float sample)
        {
            count++;
            if (enabled)
            {
                if (a != 0)
                {
                    if (count % a == 0)
                    {
                        temp = sample;
                    }
                    return temp;
                }
                else
                {
                    return sample;
                }
            }
            else
            {
                return sample;
            }
        }
    }
    public class CustomEffect3 : Effect
    {
        public bool enabled = true;
        private float a;
        private int count = 0;
        private int frequency;

        public CustomEffect3(float a = 0.2222f, int frequency = 5)
        {
            this.a = a;
            this.frequency = frequency;
        }
        public void Update(float a, int freq)
        {
            if (a > 1)
            {
                this.a = 1;
            }
            else
            {
                this.a = a;
            }
            this.frequency = freq;
        }
        public override float ApplyEffect(float sample)
        {
            if (enabled)
            {
                if (count == frequency)
                {
                    count = 0;
                    return a;
                }
                else
                {
                    count++;
                    return sample;
                }
            }
            else
            {
                return sample;
            }
        }
    }
}
