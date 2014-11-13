using System;
using JoanVilarino.Demos.ExplicitInterfaceDemo.Disambiguation;

namespace JoanVilarino.Demos.ExplicitInterfaceDemo.Tests
{
    public class DisambiguationTest
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("****************** DISAMBIGUATION TEST *******************");
            Console.WriteLine();

            var movObj = new Movie("Interstellar", 2014);
            var serObj = new Episode("The Walking Dead", 5, 1 , "No Sanctuary");

            Console.WriteLine("The movie is: {0}", movObj.GetTitle());
            Console.WriteLine("The serie is: {0}", ((IMovie)serObj).GetTitle());
            Console.WriteLine("The episode is: {0}", ((ISerie) serObj).GetTitle());

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }

    }
}
