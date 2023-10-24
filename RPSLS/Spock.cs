using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Spock : Gestures
    {
        public Spock()
        {
            this.gestureName = "Spock";
        }

        public override bool GestureInteraction(string name)
        {   
            if(name == "Lizard" || name == "Paper")
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
