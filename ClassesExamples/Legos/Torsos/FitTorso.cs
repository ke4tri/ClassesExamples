using System;

namespace ClassesExamples.Legos.Torsos
{
    class FitTorso : Torsos
    {
        public FitTorso(int numberOfArms, Sex sex = Sex.Shrug, Color color = Color.Red)
            : base(numberOfArms, sex, color, "OMG, so fit.")
        {
        }

        public void Crunch(int howManyCrunches)
        {
            FitnessOfAbdomen = FitnessOfAbdomen + " Even more fit.";
            Console.WriteLine($"I just did {howManyCrunches}, brah.  CROSSFIT!");
        }

        public override void Wave()
        {
            base.Wave();
            Console.WriteLine("(ツ)_/¯");
        }
    }
}
