
using ClassesExamples.Legos.Heads;
using ClassesExamples.Legos.Torsos;

namespace ClassesExamples.Legos
{
    class Minifigure
    {
        public Head Head { get; set; }
        public SkeletonTorso Body { get; set; }
    }

    public Minifigure(Head head, FitTorso body)
    {
        Head = head;
        body = body;
    }

    public void Eat()
    {
        Head.Chew();
        Body.Digest();
    }

    public body Greet()
    {
        Head.Talk();
        Body.Wave();
    }
}
