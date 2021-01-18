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
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();
            Console.WriteLine("                                    ______");
            Console.WriteLine("                                   /  _   )          __    ");
            Console.WriteLine("                                  /     _/__________/ /_            ");
            Console.WriteLine("                                 /  // /   / /  ___/ /_/    ");
            Console.WriteLine("                                /__//___)___/_____/_/_/   ");

            Console.WriteLine("      ______                                            ______ ");
            Console.WriteLine("     /  _   )                                          /   __/     ___                             ");
            Console.WriteLine("    /   ___/__________ _____ ___                      /__   /_____/__/________________________         ");
            Console.WriteLine("   /  //  /    /  /  /  -__/ __/                     /     /  ___/  /_  -/_  -/  / /  __/_  -/ ");
            Console.WriteLine("  /__//____(__/  ___/____//_/                       /_____/_____/__/____/____/____/__/ /____/ ");
            Console.WriteLine("             /__/                                                            ");

            Console.WriteLine("      ____                          ___           ______  ");
            Console.WriteLine("     /   /___________________ ____ /  /          /   __/               __");
            Console.WriteLine("    /   //__/__   //        //  __)  /          /__   /_______________/ /_                     ");
            Console.WriteLine("   /   //  /   __//  (     //  / (  /          /     /  _  / __ / ___/ /_/");
            Console.WriteLine("  /   //__/_____//_____(__//__/____/          /_____/  ___/____/____/_/_/              ");
            Console.WriteLine(" /_______________________________/                 /__/                                       ");
            
            Console.WriteLine("\t\t\t\t   Press Enter to Continue");
            Console.WriteLine();
            
            string startKey=Console.ReadLine();

        }

        public static void HowManyPlayers()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t\t\t How many players? \n\n\n");
            Console.WriteLine("\t\t\t Enter 1 for 1 player or 2 for 2 player");
        }
        
        public static void ChooseMove()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("\n\n");
            Console.Write("\n\t\t\t");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("              ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t    ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("                  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("          ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("              ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t    ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("                  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("          ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("               ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t    ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("                  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("          ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("               ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t    ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("                  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("          ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("                ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t    ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("                  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("          ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("               ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t    ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("                  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("          ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("              ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t    ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("                  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("          ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("             ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t    ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("                  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("          ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("             ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t    ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("                  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("          ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("              ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("  ");



            Console.Write("\n\t\t\t\t");

            Console.Write("\n\t\t\t\t 1.Rock \t   2.Paper \t 3.Scissors");
            Console.Write("\n\t\t\t\t\t\t Make your move: \n\n\n");
            Console.Write("\t\t\t\t\t 4.Lizard \t 5.Spock");
            Console.Write("\n\t\t\t\t\t   ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("              ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t\t  ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t\t   ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(" xxxx ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("              ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t\t    ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t       ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write("\t  ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t       ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write("\t  ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t       "); 
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write("\t  ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t     ");

        }


        public static void InvalidInput()
        {
            Console.WriteLine("Invalid Input. Please try again.");
        }

        public static void DisplayGameWinner(string player1, string player2, string verb)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t"+ player1+" "+verb+" "+player2);
            Console.ReadLine();
        }

        public static void BattleCountdown()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t\t\t      ______");
            Console.WriteLine("\t\t\t\t     /  _   )          __    ");
            Console.WriteLine("\t\t\t\t    /     _/__________/ /_            ");
            Console.WriteLine("\t\t\t\t   /  // /   / /  ___/ /_/    ");
            Console.WriteLine("\t\t\t\t  /__//___)___/_____/_/_/   ");
            Console.Beep(220, 500);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t\t\t      ______");
            Console.WriteLine("\t\t\t\t     /  _   )               ");
            Console.WriteLine("\t\t\t\t    /   ___/__________ _____ ___         ");
            Console.WriteLine("\t\t\t\t   /  //  /    /  /  /  -__/ __/   ");
            Console.WriteLine("\t\t\t\t  /__//____(__/  ___/____//_/  ");
            Console.WriteLine("\t\t\t\t             /__/                   ");
            Console.Beep(220, 500);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t\t\t      ______");
            Console.WriteLine("\t\t\t\t     /   __/     ___            ");
            Console.WriteLine("\t\t\t\t    /__   /_____/__/__________________________                    ");
            Console.WriteLine("\t\t\t\t   /     /  ___/  /_  -/_  -/  / /  __/_  -/        ");
            Console.WriteLine("\t\t\t\t  /_____/_____/__/____/____/____/__/ /____/                          ");
            Console.WriteLine("\t\t\t\t                   ");
            Console.Beep(220, 500);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t\t\t       ____                          ___  ");
            Console.WriteLine("\t\t\t\t      /   /___________________ ____ /  /        ");
            Console.WriteLine("\t\t\t\t     /   //__/__   //        //  __)  /            ");
            Console.WriteLine("\t\t\t\t    /   //  /   __//  (     //  / (  /         ");
            Console.WriteLine("\t\t\t\t   /   //__/_____//_____(__//__/____/                          ");
            Console.WriteLine("\t\t\t\t  /_______________________________/   ");
            Console.Beep(220, 500);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t\t\t      ______");
            Console.WriteLine("\t\t\t\t     /   __/               __  ");
            Console.WriteLine("\t\t\t\t    /__   /_______________/ /_                    ");
            Console.WriteLine("\t\t\t\t   /     /  _  / __ / ___/ /_/       ");
            Console.WriteLine("\t\t\t\t  /_____/  ___/____/____/_/_/                        ");
            Console.WriteLine("\t\t\t\t       /__/            ");
            Console.Beep(440, 500);
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
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
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
