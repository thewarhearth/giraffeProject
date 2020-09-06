using System;
using System.Security.Cryptography.X509Certificates;

namespace TestingWithGiraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object is an instance of a Class e.g. myBook

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");

            Movie shrek = new Movie("Shrek", "Adam Adamson", "dog");

            Console.WriteLine(shrek.Rating);

            Console.ReadLine();




        }


    }
}
 