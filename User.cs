using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class User : Player
    {
        public User()
        {


        }

        public Gesture ChooseGesture(List<Gesture> gestures)
        {
            
            return gesture;
        }

        public int SelectNumberOfPlayers(Menu menu)
        {
            int number;
            bool checkInput = true;
            menu.HowManyPlayers();
            string userInput = Console.ReadLine();
            bool validInput = Int32.TryParse(userInput, out number);
            while (checkInput)
            {
                if (validInput)
                {
                    if (number != 1 || number != 2)
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                        continue;
                    }
                    else
                    {
                        checkInput = false;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
            }
            return number;
        }
    }
}
