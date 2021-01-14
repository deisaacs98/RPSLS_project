using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        public List<Gesture> gestures;
        public Menu menu;
        

        public Game()
        {
            gestures = new List<Gesture>();
            

        }

        public void RunGame()
        {
            menu = new Menu();
            menu.Title();
            SelectNumberOfPlayers(menu);


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
