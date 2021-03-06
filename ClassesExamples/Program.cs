﻿using System;
using ClassesExamples.Legos.Heads;
using ClassesExamples.Legos.Torsos;

namespace ClassesExamples //NameSpace
{
    class Program
    {

        //private string _myData = "this is just for me to use"; //Field

        //public int Number { get; set; } //Property

        //public void DoTheTHing() Propertices, caps
        //{
        //    Number = 1;
        //    var x = Number;
        //}

        private static void Main(string[] args) //Method. by nature is private can leave out
        {
            //var taffy = new Candy();
            //taffy.Flavor = "Orange";
            //taffy.Name = "Orange Saltwater Taffy";
            //taffy.Rating = 5;
            //taffy.Type = CandyType.Stretchy;

            var taffy = new Candy("Orange", "Orange Saltwater Taffy", CandyType.Stretchy);

            taffy.SetRating(10);
            taffy.SetRating(5, "Just kinda liked it.");
                
            Console.WriteLine(taffy.ToString());

            var myDogHead = new Dog();
            var martinHead = new Bald();
            var astronaught = new Astronaut();

            var fitTorso = new FitTorso(2, Sex.Male, Legos.Color.Frecles);
            fitTorso.Crunch(12);

            Console.ReadLine();
        }
    }
}




