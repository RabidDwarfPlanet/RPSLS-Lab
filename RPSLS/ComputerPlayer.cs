using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{

    internal class ComputerPlayer : Player
    {
        Random rand = new Random();
        public ComputerPlayer(string playerName)
            : base(playerName)
        {

        }

        public override void ChooseGesture(List<Gestures> gesture)
        {
            chosenGesture = gesture[rand.Next(5)];
        }
    }
}
