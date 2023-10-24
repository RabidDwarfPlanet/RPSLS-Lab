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

        public override void ChooseGesture(List<Gestures> gesture)
        {
            this.chosenGesture = null;
            Console.Clear();
            Console.WriteLine($"{this.name} what gesture would you like to play?");
            if (score == 1)
            {
                Console.WriteLine($"You have {score} point");
            }
            else
            {
                Console.WriteLine($"You have {score} points\n");
            }
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(gesture[i].gestureName);
            }
            retry:
            string chosenGesture = Console.ReadLine();
            for(int i = 0; i < 5; i++)
            {
                if(chosenGesture.ToLower() == gesture[i].gestureName.ToLower())
                {
                    this.chosenGesture = gesture[i];
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
