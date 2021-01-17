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
            Console.WriteLine("\n\n\n\n\t\t\t Rock/Paper/Scissors/Lizard/Spock \n\n\n");
            Console.WriteLine("\t\t\t Press Enter to Continue");
            Console.ReadLine();
        }

        public static void HowManyPlayers()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t\t\t How many players? \n\n\n");
            Console.WriteLine("\t\t\t Enter 1 for 1 player or 2 for 2 player");
        }
        
        public static void ChooseMove()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t\t Make your move: \n\n\n");
            Console.WriteLine("\t 1.Rock \t 2.Paper \t 3.Scissors");          
            Console.WriteLine("\t\t 4.Lizard \t 5.Spock");
        }

        public static void InvalidInput()
        {
            Console.WriteLine("Invalid Input. Please try again.");
        }

        public static void DisplayGameWinner(string player1, string player2, string verb)
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t"+ player1+" "+verb+" "+player2);
        }

        public static void DisplayMatchWinner(string winner)
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t\t" + winner + " has won the match!");
            Console.ReadLine();
        }

        public static void DisplayTie()
        {
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
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t Would you like to play again?");
            Console.WriteLine("\n\t\t Press Y for Yes");
            string response = Console.ReadLine();
            return response;
            
        }
    }
}
