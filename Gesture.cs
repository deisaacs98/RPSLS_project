using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Gesture
    {
        public string Name;
        public string Verb1;
        public string Verb2;

        public Gesture(string name, string verb1, string verb2)
        {
            Name = name;
            Verb1 = verb1;
            Verb2 = verb2;

        }
    }
}
