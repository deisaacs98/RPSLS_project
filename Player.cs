using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        public Gesture gesture;
        public List<Gesture> gestures;
        public int wins;
        
        public Player()
        {
            wins = 0;
        }

        public virtual Gesture ChooseGesture()
        {
            List<Gesture> gestures = Game.gestures;

            Menu.ChooseMove();
            bool checkInput = true;
            int gestureNumber;
            string userInput = Console.ReadLine();
            bool validInput = Int32.TryParse(userInput, out gestureNumber);
            while (checkInput)
            {
                if (validInput)
                {
                    if (gestureNumber < 0 || gestureNumber > 4)
                    {
                        Console.WriteLine("Invalid input. Please try again."); ;
                    }
                        gesture = gestures[gestureNumber];
                }
                return gesture;
            }
        }
        public int SelectNumberOfPlayers()
        {
            int number;
            bool checkInput = true;
            Menu.HowManyPlayers();
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
        // What does a player do?







    }


}
