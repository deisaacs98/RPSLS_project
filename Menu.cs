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
            // Same graphics as for ChooseMove. Need to create separate methods for graphics, possibly in Gesture class. Inheritance could be useful.
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
            Console.WriteLine("\n\n\t\t\t\t\t  4.Lizard \t      5.Spock");
        }


        public static void InvalidInput()
        {
            Console.WriteLine("Invalid Input. Please try again.");
        }

        public static void DisplayGameWinner(string player1, string player2, string verb)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t" + player1 + " " + verb + " " + player2 + "!!!!");
        }

        public static void BattleCountdown()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Graphics.RockTextGraphic();
            
            Console.Beep(349, 600);
            
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Graphics.PaperTextGraphic();
            
            Console.Beep(622, 900);
            
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Graphics.ScissorsTextGraphic();
            Console.Beep(587, 300);
            Console.Beep(523, 200);
            
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Graphics.LizardTextGraphic();
            
            Console.Beep(466, 200);
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Graphics.SpockTextGraphic();
            
            Console.Beep(440, 200);
            Console.Beep(415, 2100);

        }

        public static void DisplayMatchWinner(string winner)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t\t" + winner + " has won the match!");
            Console.ReadLine();
        }

        public static void DisplayTie()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t TIE! \n\n\n");
            Console.WriteLine("\t\t Press Enter to Choose Again");
            Console.ReadLine();
        }

        public static void DisplayScore(Player player1, Player player2)
        {

            Console.WriteLine("\n\t\t Player 1: "+player1.wins);
            Console.WriteLine("\t\t Player 2: "+player2.wins);
            Console.ReadLine();
        }
        public static string PlayAgain()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t Would you like to play again?");
            Console.WriteLine("\n\t\t Press Y for Yes");
            string response = Console.ReadLine();
            return response;
            
        }


    }
}
