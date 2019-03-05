using System;
using System.Collections.Generic;
using System.Text;
using ClassesExamples.Legos.Heads;

namespace ClassesExamples.Legos.Torso
{
    abstract class Torso
    {
        public int NumberOfArms { get; protected set; }
        public string FitnessOfAbdomen { get; protected set; }
        public Sex Sex { get; protected set; }
        public Colors Color { get; protected set; }

        protected Torso(int numOfArms, Sex sex, Colors color, string fitnessOfAbdomen)
        {
            NumberOfArms = numOfArms;
            Sex = sex;
            Color = color;
            FitnessOfAbdomen = fitnessOfAbdomen;
        }

        public virtual void Wave()
        {

            Console.WriteLine("Waves hello 0/");
        }
    }

    internal enum Sex
    {
        Male,
        Female,
        Other,
        Shrug
    }
}
