using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string playerName)
            :base(playerName)
        {

        }

        public void NamePlayer() 
        {
            this.name = Console.ReadLine();
        }

        public override void ChooseGesture()
        {
            Console.WriteLine("What gesture would you like to play?");
            foreach(string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
            retry:
            string chosenGesture = Console.ReadLine();
            foreach(string gesture in gestures)
            {
                if(gesture.ToLower() == chosenGesture.ToLower())
                {
                    chosenGesture = gesture;
                }
                else
                {
                    Console.WriteLine("This is not a valid gesture, please try again");
                    goto retry;
                }
            }
        }
    }
}
