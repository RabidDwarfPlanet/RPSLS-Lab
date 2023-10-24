using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPSLS
{
    internal class Paper : Gestures
    {
        public Paper()
        {
            this.gestureName = "Paper";
        }

        public override bool GestureInteraction(string name)
        {
            if (name == "Lizard" || name == "Scissors")
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
