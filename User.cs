using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class User : Player
    {
        public int number;
        public User()
        {
        }

        public override int ChooseGesture()
        {
            Menu.ChooseMove();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            bool checkInput = true;
            int gestureNumber = 0;
            
            
            while (checkInput)
            {
                string userInput = Console.ReadLine();
                bool validInput = Int32.TryParse(userInput, out gestureNumber);
                if (validInput)
                {
                    if ((gestureNumber < 1) || (gestureNumber > 5))
                    {
                        Console.WriteLine("\n\n\t\t\t\tInvalid input. Please try again.");
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
                    Console.WriteLine("\n\n\t\t\t\tInvalid input. Please try again.");
                    continue;
                }            
            }
            gestureNumber--;
            return gestureNumber;
        }

        public int SelectNumberOfPlayers()
        {
            bool checkInput = true;
            Menu.HowManyPlayers();
            while (checkInput)
            {
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string userInput = Console.ReadLine();
                bool validInput = Int32.TryParse(userInput, out number);

                if (validInput)
                {
                    if ((number != 1) && (number != 2))
                    {
                        Menu.InvalidInput();
                        validInput = false;
                        continue;
                    }
                    else
                    {
                        checkInput = false;
                        validInput = false;
                        break;
                    }                    
                }
                else
                {
                    Menu.InvalidInput();
                    continue;
                }
            }
            return number;
        }

        public void AddGesturesToList()
        {
            Gesture gesture1 = new Gesture("Rock", "crushes", "crushes");
            Gesture gesture2 = new Gesture("Paper", "covers", "disproves");
            Gesture gesture3 = new Gesture("Scissors", "cuts", "decapitates");
            Gesture gesture4 = new Gesture("Lizard", "poisons", "eats");
            Gesture gesture5 = new Gesture("Spock", "smashes", "vaporizes");
            gestures.Add(gesture1);
            gestures.Add(gesture2);
            gestures.Add(gesture3);
            gestures.Add(gesture4);
            gestures.Add(gesture5);
        }
    }
}
