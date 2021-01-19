using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public static class Menu
    {
        static Menu()
        {
        }
        public static void Title()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Graphics.TitleGraphic();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\n\n\n\n\n\t\t\t\t\t\tPress Enter to Continue");
            Console.WriteLine();
            Console.ReadLine();
        }

            

        public static void HowManyPlayers()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Graphics.SelectModeGraphic();
            Console.WriteLine("\n\n\t\t\t\t\t\t How many players? \n\n");
            Console.WriteLine("\t\t\t\t\t Enter 1 for 1 player or 2 for 2 player");
            Graphics.RockPaperScissorsGraphic();
            Graphics.LizardSpockGraphic();
        }
        
        public static void ChooseMove()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("\n");
            Console.Write("\n\t\t\t\t1.Rock \t\t     2.Paper \t\t   3.Scissors");
            Graphics.RockPaperScissorsGraphic();
            Console.Write("\n\t\t\t\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n\t\t\t\t\t\t MAKE YOUR MOVE!!!!");
            Console.Write("\n\n\t\t\t\t\tPick a move and enter its number \n\n");
            Graphics.LizardSpockGraphic();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\t\t\t\t\t  4.Lizard \t      5.Spock \n\n");
        }

        public static void InvalidInput()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("\t\t\t\t\tInvalid Input. Please try again.");
        }

        //Had to brute force this for the graphics. Will refactor in the future.
        public static void DisplayGameWinner(string player1, string player2, string verb)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t\t\t\t" + player1 + " " + verb + " " + player2 + "!!!!");
            switch(player1)
            {
                case "Rock":
                    if(player2=="Paper")
                    {
                        Graphics.BattleGraphic3();
                        break;
                        
                    }
                    else if (player2 == "Scissors")
                    {
                        Graphics.BattleGraphic1();
                        break;
                    }
                    else if (player2 == "Lizard")
                    {
                        Graphics.BattleGraphic2();
                        break;
                    }
                    else if (player2 == "Spock")
                    {
                        Graphics.BattleGraphic10();
                        break;
                    }
                    else
                    {
                        break;
                    }
                    
                case "Paper":
                    if (player2 == "Rock")
                    {
                        Graphics.BattleGraphic3();
                        break;
                    }
                    else if (player2 == "Scissors")
                    {
                        Graphics.BattleGraphic5();
                        break;
                    }
                    else if (player2 == "Lizard")
                    {
                        Graphics.BattleGraphic8();
                        break;
                    }
                    else if (player2 == "Spock")
                    {
                        Graphics.BattleGraphic4();
                        break;
                    }
                    else
                    {
                        break;
                    }
                case "Scissors":
                    if (player2 == "Rock")
                    {
                        Graphics.BattleGraphic1();
                        break;
                    }
                    else if (player2 == "Paper")
                    {
                        Graphics.BattleGraphic5();
                        break;
                    }
                    else if (player2 == "Lizard")
                    {
                        Graphics.BattleGraphic6();
                        break;
                    }
                    else if (player2 == "Spock")
                    {
                        Graphics.BattleGraphic9();
                        break;
                    }
                    else
                    {
                        break;
                    }
                case "Lizard":
                    if (player2 == "Paper")
                    {
                        Graphics.BattleGraphic8();
                        break; ;
                    }
                    else if (player2 == "Scissors")
                    {
                        Graphics.BattleGraphic6();
                        break;
                    }
                    else if (player2 == "Rock")
                    {
                        Graphics.BattleGraphic2();
                        break;
                    }
                    else if (player2 == "Spock")
                    {
                        Graphics.BattleGraphic7();
                        break;
                    }
                    else
                    {
                        break;
                    }
                case "Spock":
                    if (player2 == "Paper")
                    {
                        Graphics.BattleGraphic4();
                        break;
                    }
                    else if (player2 == "Scissors")
                    {
                        Graphics.BattleGraphic9();
                        break;
                    }
                    else if (player2 == "Lizard")
                    {
                        Graphics.BattleGraphic7();
                        break;
                    }
                    else if (player2 == "Rock")
                    {
                        Graphics.BattleGraphic10();
                        break;
                    }
                    else
                    {
                        break;
                    }
                default:
                    break;
            }
        }

        public static void BattleCountdown()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Graphics.RockTextGraphic();
            Graphics.RockGraphic();
            Console.Beep(349, 600);
            Console.Clear();
            Graphics.PaperTextGraphic();
            Graphics.PaperGraphic();
            Console.Beep(622, 900);
            Console.Clear();
            Graphics.ScissorsTextGraphic();
            Graphics.ScissorsGraphic();
            Console.Beep(587, 300);
            Console.Beep(523, 200);  
            Console.Clear();
            Graphics.LizardTextGraphic();
            Graphics.LizardGraphic();
            Console.Beep(466, 200);
            Console.Clear();
            Graphics.SpockTextGraphic();
            Graphics.SpockGraphic();
            Console.Beep(440, 200);
            Console.Beep(415, 2100);
        }

        public static void DisplayMatchWinner(string winner)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t\t\t" + winner + " has won the match!");
            Console.ReadLine();
            

        }

        public static void DisplayTie()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t\t\t\t TIE! \n\n\n");
            Console.WriteLine("\n\n\t\t\t\t\t Press Enter to Choose Again");
            Console.ReadLine();
        }

        public static void DisplayScore(Player player1, Player player2)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\n\t\t\t\t\t Player 1: "+player1.wins);
            Console.WriteLine("\t\t\t\t\t Player 2: "+player2.wins);
            Console.ReadLine();
        }
        public static string PlayAgain()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t\t\t\t Would you like to play again?");
            Console.WriteLine("\n\t\t\t\t\t Press Y for Yes");
            string response = Console.ReadLine();
            return response;
            
        }


    }
}
