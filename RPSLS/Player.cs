using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal abstract class Player
    {
        //Member Variabes (HAS A)
        public string name;
        public Gestures chosenGesture;
        public int score;

        //Constructor
        public Player(string name)
        {
            this.name = name;
            chosenGesture = null;
            score = 0;
        }

        //Member Methods (CAN DO)
        //This abstract method must be overridden by the child Player classes
        public abstract void ChooseGesture(List<Gestures> name);
    }
}
