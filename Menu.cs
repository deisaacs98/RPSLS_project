﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Menu
    {
        public Menu()
        {

        }
        public void Title()
        {
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("              Rock/Paper/Scissors/Lizard/Spock                         ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                  Press Enter to Continue");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
            
        }
        public void HowManyPlayers()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                  How many players?                         ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("       Enter 1 for 1 player or 2 for 2 player");
            Console.WriteLine();
            Console.WriteLine();
        }
        
        public void ChooseMove()
        {
            Console.Clear()
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                    Make your move:                         ");
            Console.WriteLine();
            Console.WriteLine("      1.Rock           2.Paper          3.Scissors");          
            Console.WriteLine("            4.Lizard            5.Spock              ");
            Console.WriteLine();
        }

    }
}
