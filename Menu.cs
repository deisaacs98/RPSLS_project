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
            Console.Clear()  
        }
        public static void HowManyPlayers()
        {
            Console.WriteLine("\n\n\n\n\t\t\t How many players? \n\n\n");
            Console.WriteLine("\t\t\t Enter 1 for 1 player or 2 for 2 player");
        }
        
        public static void ChooseMove()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t\t Make your move: \n\n\n");
            Console.WriteLine("\t 1.Rock \t 2.Paper \t 3.Scissors");          
            Console.WriteLine("\t 4.Lizard \t 5.Spock");
        }
    }
}
