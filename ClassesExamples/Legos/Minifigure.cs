
using System;
using System.Collections.Generic;
using System.Text;
using ClassesExamples.Legos.Heads;
using ClassesExamples.Legos.Torsos;

namespace ClassesExamples.Legos
{
    class Minifigure
    {
        public Head Head { get; set; }
        public Torsos Body { get; set; }
    }

    public Minifigure(Head head, Torso body)
    {
        Head = head;
        Body = body;
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
