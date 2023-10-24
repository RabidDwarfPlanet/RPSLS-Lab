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
        int scoreCap;
        Rock rock = new Rock();
        Scissors scissors = new Scissors();
        Spock spock = new Spock();
        Lizard lizard = new Lizard();
        Paper paper = new Paper();
        List<Gestures> gesturesList = new List<Gestures>();


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

        public void ScoreCap()
        {
            Console.WriteLine("\nHow many points would you like this game to go to");
        retry:
            string input = Console.ReadLine();
            bool num = int.TryParse(input, out int scoreCap);
            if (num == true)
            {
                this.scoreCap = scoreCap;
            }
            else
            {
                Console.WriteLine("That is not a number, please try again");
                goto retry;
            }
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("\nHow many players would you like this game to have?");
        retry:
            string input = Console.ReadLine();
            bool num = int.TryParse(input, out int numberOfHumanPlayers);
            if(numberOfHumanPlayers >= 0 && numberOfHumanPlayers < 3 && num == true)
            {
                return numberOfHumanPlayers;
            }
            else if(num == true)
            {
                Console.WriteLine("That is not a valid number of players, please try again");
                goto retry;
            }
            else
            {
                Console.WriteLine("Please enter a number");
                goto retry;
            }
            
        }



        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            Console.Clear();
            if(numberOfHumanPlayers == 1)
            {
                playerOne = new HumanPlayer(null);
                Console.WriteLine("What would you like to name your player");
                playerOne.name = Console.ReadLine();
                playerTwo = new ComputerPlayer("B0T");
            }
            else if (numberOfHumanPlayers == 2)
            {
                playerOne = new HumanPlayer(null);
                Console.WriteLine("What would you like to name your first player");
                playerOne.name = Console.ReadLine();
                Console.Clear();
                playerTwo = new HumanPlayer(null);
                Console.WriteLine("What would you like to name your seccond player");
                playerTwo.name = Console.ReadLine();
            }
            else
            {
                playerOne = new ComputerPlayer("B0T");
                playerTwo = new ComputerPlayer("B1M");
            }
        }


        public void CompareGestures()
        {
            Console.Clear();
            Console.WriteLine($"{playerOne.name} has played {playerOne.chosenGesture.gestureName} and {playerTwo.name} has played {playerTwo.chosenGesture.gestureName}");
            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("This round is a tie");
            }
            if (playerOne.chosenGesture.GestureInteraction(playerTwo.chosenGesture.gestureName) == true)
            {
                Console.WriteLine($"{playerOne.name} has won this round!");
                playerOne.score += 1;
            }
            else
            {
                Console.WriteLine($"{playerTwo.name} has won this round!");
                playerTwo.score += 1;
            }
                
            
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        public void DisplayGameWinner()
        {
            Console.Clear();
            if (playerOne.score == scoreCap)
            {
                Console.WriteLine($"{playerOne.name} has won!");
            }
            else if (playerTwo.score == scoreCap)
            {
                Console.WriteLine($"{playerTwo.name} has won!");
            }
        }

        public void RunGame()
        {
            gesturesList.Add(rock); gesturesList.Add(paper); gesturesList.Add(scissors); gesturesList.Add(lizard); gesturesList.Add(spock);
            WelcomeMessage();
            ScoreCap();
            CreatePlayerObjects(ChooseNumberOfHumanPlayers());
        replay:
            playerOne.score = 0;
            playerTwo.score = 0;
            while (playerOne.score < scoreCap && playerTwo.score < scoreCap)
            {
                playerOne.ChooseGesture(gesturesList);
                playerTwo.ChooseGesture(gesturesList);
                CompareGestures();

            }
            DisplayGameWinner();
            if (ReplayGame() == "yes") { goto replay; }
            else { Environment.Exit(0); }


        }

        public string ReplayGame()
        {
            Console.WriteLine("\nWould you replay this game? Type YES to restart it or type NO to close the game");
            retry:
            string replayAnswer = Console.ReadLine();
            if (replayAnswer.ToLower() == "yes" || replayAnswer.ToLower() == "y")
            {
                return "yes";
            }
            else if (replayAnswer.ToLower() == "no" || replayAnswer.ToLower() == "n")
            {
                return "no";
            }
            else
            {
                Console.WriteLine("Not a valid answer, please try again");
                goto retry;
            }
            
        }
    }
}
