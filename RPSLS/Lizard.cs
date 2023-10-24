using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPSLS
{
    internal class Lizard : Gestures
    {
        public Lizard()
        {
            this.gestureName = "Lizard";
        }

        public override bool GestureInteraction(string name)
        {
            if (name == "Rock" || name == "Scissors")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
