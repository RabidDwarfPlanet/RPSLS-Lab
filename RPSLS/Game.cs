using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:");
            Console.WriteLine("This game is a more complex version of Rock Paper Scissors with some new options\nIn this version of the game");
            Console.WriteLine("Rock breaks Scissors\nScissors slices Paper \nPaper smothers Rock\nRock kills Lizard\nLizard kills Spock\nSpock breaks Scissors\nScissors kills Lizard\nLizard ruins Paper\nPaper reprimand Spock\nSpock disintegrate Rock");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("\nHow many players would you like this game to have?");
            retry:
            int numberOfHumanPlayers = int.Parse(Console.ReadLine());
            if(numberOfHumanPlayers < 0 || numberOfHumanPlayers > 2)
            {
                Console.WriteLine("That is not a valid number of players, please try again");
                goto retry;
            }
            else
            {
                return numberOfHumanPlayers;
            }
            
        }



        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if(numberOfHumanPlayers == 1)
            {
                HumanPlayer playerOne = new HumanPlayer(null);
                Console.WriteLine("What would you like to name your player");
                playerOne.NamePlayer();
                ComputerPlayer comOne = new ComputerPlayer("B0T");
            }
            else
            {
                HumanPlayer playerOne = new HumanPlayer(null);
                Console.WriteLine("What would you like to name your first player");
                playerOne.NamePlayer();
                HumanPlayer playerTwo = new HumanPlayer(null);
                Console.WriteLine("What would you like to name your seccond player");
                playerTwo.NamePlayer();
            }
            
        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
            CreatePlayerObjects(ChooseNumberOfHumanPlayers());

        }
    }
}
