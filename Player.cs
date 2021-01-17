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

        public virtual int ChooseGesture()
        {
            int tempNumber = 0;
            return tempNumber;
        }
    }
}
