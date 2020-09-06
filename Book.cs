using System;
using System.Collections.Generic;
using System.Text;

namespace TestingWithGiraffe
{
    class Book
    {
        public string title; //Called 'Class Attributes'
        public string author;
        private string rating;

        

        public Book() { }

        public Book(string aTitle, string aAuthor, string aRating)
        {
            title = aTitle;
            author = aAuthor;
            rating = aRating;
        }

        // Getter and Setter
        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "A" || value == "PG" || value == "R")
                {
                    rating = value;
                    Console.WriteLine("if");
                }
                else
                    Console.WriteLine("else");
                    rating = "NR";


            }

        }




    }
}
