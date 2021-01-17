using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class CPU : Player
    {
        public CPU()
        {

        }
        public override int ChooseGesture()
        {
            Random random = new Random();
            int gestureNumber = random.Next(0, 5);
            return gestureNumber;
        }
    }
}
