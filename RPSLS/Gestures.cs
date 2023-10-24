using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal abstract class Gestures
    {
        public string gestureName;

        public Gestures()
        {

        }

        public abstract bool GestureInteraction(string name);
    }
}
