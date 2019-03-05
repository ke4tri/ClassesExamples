using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Heads
{
    class Astronaut : Head 
    {
        public List<string> Accessories { get; set; }


        public override string Talk()
        {

            return $"Houston we have a problem... I have {HairLength} long hair and Im {Color}" +
                $"and my ears are {EarSize}";
        }
    }
}
