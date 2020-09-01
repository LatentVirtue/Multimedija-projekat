using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPJPlayer
{
    public abstract class Effect : IEffect
    {
        public abstract float ApplyEffect(float sample);

    }
}
