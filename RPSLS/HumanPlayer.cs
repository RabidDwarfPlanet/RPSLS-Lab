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

        public override void ChooseGesture()
        {
            this.chosenGesture = null;
            Console.Clear();
            Console.WriteLine($"{this.name} what gesture would you like to play?");
            foreach(string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
            retry:
            string chosenGesture = Console.ReadLine();
            foreach(string gesture in gestures)
            {
                if(chosenGesture.ToLower() == gesture.ToLower())
                {
                    this.chosenGesture = gesture;
                    break;
                }
            }
            if (this.chosenGesture == null)
            {
                Console.WriteLine("This is not a valid gesture, please try again");
                goto retry;
            }
        }
    }
}
