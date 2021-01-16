using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {

        public List<Gesture> gestures = new List<Gesture>();
        public int wins;
        
        public Player()
        {
            wins = 0;
            
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

        public virtual int ChooseGesture()
        {
            Random random = new Random();
            int gestureNumber = random.Next(0, 5);
            return gestureNumber;
        }






    }


}
