using System;
using System.Collections.Generic;

namespace TuesdayLesson2
{
    class Program
    {
        // https://www.youtube.com/playlist?list=PLAC325451207E3105
        // https://www.youtube.com/watch?v=gfkTfcpWqAY
        // https://www.youtube.com/watch?v=BfEjDD8mWYg // playlist by kudenvat 

        static void Main(string[] args)
        {
            string Powers = "flying, swimming, invisible";

            List<string> listOfPowers = new List<string>();


            listOfPowers.Add("Flying");
            listOfPowers.Add("Swimming");
            listOfPowers.Add("Invisible");

            Console.WriteLine($"The list of powers has {listOfPowers.Count} items");

            foreach(string currentItem in listOfPowers)
            {

                Console.WriteLine($"The current item in the list is {currentItem}");
            }

            // Richard Of York Gave Battle In Vain - how to remember 
            List<string> rainbowColours = new List<string>() { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };


            // output the rain bow colours as a code challenge

            // put your code here


            foreach (string currentItem in rainbowColours)
            {

                Console.WriteLine($"The current item in the list is {currentItem}");
            }

            SuperHero myFirstHero = new SuperHero("Batman");

            Console.WriteLine(myFirstHero.SampleMethod());
            Console.WriteLine(myFirstHero.GetName());


        }
    }
}
