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
            bool checkInput = true;
            int gestureNumber;
            string userInput = Console.ReadLine();
            bool validInput = Int32.TryParse(userInput, out gestureNumber);
            while (checkInput)
            {
                if (validInput)
                {
                    if ((gestureNumber < 1)|| (gestureNumber > 5))
                    {
                        Console.WriteLine("Invalid input. Please try again."); 
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
            bool checkInput = true;
            Menu.HowManyPlayers();
            string userInput = Console.ReadLine();
            while (checkInput)
            {
                bool validInput = Int32.TryParse(userInput, out number);
                while (validInput)
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
