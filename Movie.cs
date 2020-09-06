using System;
using System.Collections.Generic;
using System.Text;

namespace TestingWithGiraffe
{
    class Movie
    {

        public string title;
        public string director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating; //Notice, this is Rating and not rating.
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "PG" || value == "PG-13")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }

        }

    }
}
