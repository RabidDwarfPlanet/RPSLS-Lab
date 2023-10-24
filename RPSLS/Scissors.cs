using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPSLS
{
    internal class Scissors : Gestures
    {
        public Scissors()
        {
            this.gestureName = "Scissors";
        }

        public override bool GestureInteraction(string name)
        {
            if (name == "Rock" || name == "Spock")
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
