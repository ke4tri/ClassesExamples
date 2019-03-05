using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Torsos
{
    class Torsos : Torso
    {

        public Torsos(int numberOfArms)
            : base (numberOfArms, Sex.Shrug, Color.Bone, "bony")
        {

        }

        public void Rattle()
        {
            Console.WriteLine("Rattle Rattle...");
            Wave();
        }
    }
}
