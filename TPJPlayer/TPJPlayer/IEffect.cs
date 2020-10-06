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
}
