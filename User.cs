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

        public override int ChooseGesture()
        {

            Menu.ChooseMove();
            bool checkInput = true;
            int gestureNumber;
            string userInput = Console.ReadLine();
            bool validInput = Int32.TryParse(userInput, out gestureNumber);
            while (checkInput)
            {
                if (validInput)
                {
                    if (gestureNumber < 1 || gestureNumber > 5)
                    {
                        Console.WriteLine("Invalid input. Please try again."); ;
                    }
                    checkInput = false;
                }
                else
                {
                    
                    break;
                }            
            }
            gestureNumber--;
            return gestureNumber;

        }
        public int SelectNumberOfPlayers()
        {
            int number=0;
            bool checkInput = true;
            Menu.HowManyPlayers();
            
            
            while (checkInput)
            {
                string userInput = Console.ReadLine();
                bool validInput = Int32.TryParse(userInput, out number);
                while (validInput)
                {
                    if (number != 1 && number != 2)
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                        validInput = false;
                        continue;
                    }
                    else
                    {
                        checkInput = false;
                        break;
                    }


                }
                Console.WriteLine("Invalid input. Please try again.");
                validInput = false;
                continue;
      
            }
            return number;
        }


    }
}
