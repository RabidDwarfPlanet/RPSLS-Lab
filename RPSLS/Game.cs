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
            Console.WriteLine("This is a best of 3 game, so the first player to win twice wins the game");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("\nHow many players would you like this game to have?");
        retry:
            string input = Console.ReadLine();
            bool num = int.TryParse(input, out int numberOfHumanPlayers);
            if(numberOfHumanPlayers > 0 && numberOfHumanPlayers < 3 && num == true)
            {
                return numberOfHumanPlayers;
            }
            else
            {
                Console.WriteLine("That is not a valid number of players, please try again");
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
            else
            {
                playerOne = new HumanPlayer(null);
                Console.WriteLine("What would you like to name your first player");
                playerOne.name = Console.ReadLine();
                Console.Clear();
                playerTwo = new HumanPlayer(null);
                Console.WriteLine("What would you like to name your seccond player");
                playerTwo.name = Console.ReadLine();
            }
        }


        public void CompareGestures()
        {
            Console.Clear();
            Console.WriteLine($"{playerOne.name} has played {playerOne.chosenGesture} and {playerTwo.name} has played {playerTwo.chosenGesture}");
            switch(playerOne.chosenGesture)
            {
                case "rock":
                    if (playerTwo.chosenGesture == "rock")
                    {
                        Console.WriteLine("This round is a tie");
                    }
                    else if(playerTwo.chosenGesture == "lizard" || playerTwo.chosenGesture == "scissors")
                    {
                        Console.WriteLine($"{playerOne.name} has won this round!");
                        playerOne.score += 1;
                    }
                    else
                    {
                        Console.WriteLine($"{playerTwo.name} has won this round!");
                        playerTwo.score += 1;
                    }
                    break;
                case "scissors":
                    if (playerTwo.chosenGesture == "scissors")
                    {
                        Console.WriteLine("This round is a tie");
                    }
                    else if (playerTwo.chosenGesture == "lizard" || playerTwo.chosenGesture == "paper")
                    {
                        Console.WriteLine($"{playerOne.name} has won this round!");
                        playerOne.score += 1;
                    }
                    else
                    {
                        Console.WriteLine($"{playerTwo.name} has won this round!");
                        playerTwo.score += 1;
                    }
                    break;
                case "paper":
                    if (playerTwo.chosenGesture == "paper")
                    {
                        Console.WriteLine("This round is a tie");
                    }
                    else if (playerTwo.chosenGesture == "Spock" || playerTwo.chosenGesture == "rock")
                    {
                        Console.WriteLine($"{playerOne.name} has won this round!");
                        playerOne.score += 1;
                    }
                    else
                    {
                        Console.WriteLine($"{playerTwo.name} has won this round!");
                        playerTwo.score += 1;
                    }
                    break;
                case "lizard":
                    if(playerTwo.chosenGesture == "lizard")
                    {
                        Console.WriteLine("This round is a tie");
                    }
                    else if (playerTwo.chosenGesture == "Spock" || playerTwo.chosenGesture == "paper")
                    {
                        Console.WriteLine($"{playerOne.name} has won this round!");
                        playerOne.score += 1;
                    }
                    else
                    {
                        Console.WriteLine($"{playerTwo.name} has won this round!");
                        playerTwo.score += 1;
                    }
                    break;
                case "Spock":
                    if (playerTwo.chosenGesture == "Spock")
                    {
                        Console.WriteLine("This round is a tie");
                    }
                    else if (playerTwo.chosenGesture == "Rock" || playerTwo.chosenGesture == "scissors")
                    {
                        Console.WriteLine($"{playerOne.name} has won this round!");
                        playerOne.score += 1;
                    }
                    else
                    {
                        Console.WriteLine($"{playerTwo.name} has won this round!");
                        playerTwo.score += 1;
                    }
                    break;
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        public void DisplayGameWinner()
        {
            Console.Clear();
            if (playerOne.score == 2)
            {
                Console.WriteLine($"{playerOne.name} has won!");
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine($"{playerTwo.name} has won!");
            }
        }

        public void RunGame()
        {
            WelcomeMessage();
            CreatePlayerObjects(ChooseNumberOfHumanPlayers());
        replay:
            playerOne.score = 0;
            playerTwo.score = 0;
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
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
