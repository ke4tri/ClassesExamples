using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples
{
    class Candy
    {
        //Properties
        public string Flavor { get; private set; }
        public int Rating { get; private set; }
        public string Review { get; private set; };
        public string Name { get; private set; }
        public CandyType Type { get; private set; }

        //Fields
        const int MinRatingValue = 1;  //Feild
        const int MaxRatingValue = 10;  //Feild

        //Constructor
        public Candy(string flavor,string name, CandyType type)
        {
            Flavor = flavor;
            Name = name;
            Type = type; 
        }

        //Methods
        public void SetRating(int userRating)
        {
            if (userRating >= MinRatingValue && userRating <= MaxRatingValue)
            {
                Rating = userRating;
            }
            else
            {
                throw new Exception($"You are dumb. Ratings are {MinRatingValue}-{MaxRatingValue}. You moron.");
            }
        }

        public void SetRating(int userRating, string review)
        {
            SetRating(userRating);
            Review = review;
        }
    }

    enum CandyType // Are just numbers under the hood
    {
        Chocolate,
        HardCandy,
        Caramel,
        Sour,
        Stretchy,
        Nut
    }
}
