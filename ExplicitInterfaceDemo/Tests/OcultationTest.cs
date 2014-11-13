using System;
using JoanVilarino.Demos.ExplicitInterfaceDemo.Ocultation;

namespace JoanVilarino.Demos.ExplicitInterfaceDemo.Tests
{
    public class OcultationTest
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("****************** DISAMBIGUATION TEST *******************");
            Console.WriteLine();

            using (var myObj = new MyFile())
            {
                // Here .. the user can't call Dispose unless it's casted to 
                // his IDisposable interface, so myObj.Dispose() wouldn't compile.
                Console.WriteLine("The object has been instantiated.");
            }
            
            // Anyway, the using block WILL call Dispose since it takes the argument
            // as IDisposable
            Console.WriteLine("The object has been disposed!");

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadLine();

        }

    }
}