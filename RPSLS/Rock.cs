using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPSLS
{
    internal class Rock : Gestures
    {
        public Rock()
        {
            this.gestureName = "Rock";
        }

        public override bool GestureInteraction(string name)
        {
            if (name == "Paper" || name == "Spock")
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
