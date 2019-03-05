﻿using System;
using System.Collections.Generic;
using System.Text;
using ClassesExamples.Legos.Heads;

namespace ClassesExamples.Legos.Torsos
{
    class FitTorso : Torso
    {
        private object howManyCrunches;

        public FitTorso(int numberOfArms, Sex sex, Colors color) : 
            base(numberOfArms, sex, color, "OMG, so fit")
        {
        }

        public void Crunch(int howManyCunches)
        {
            FitnessOfAbdomen = FitnessOfAbdomen + " Even more fit.";
            Console.WriteLine($"I just did {howManyCrunches}, brah. CROSSFIT!");

        }

        public override void Wave()
        {
            base.Wave();
            Console.WriteLine("(ツ)_/¯");

        }


    }
}