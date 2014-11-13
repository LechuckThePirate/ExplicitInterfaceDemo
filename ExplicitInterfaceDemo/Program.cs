using System;

namespace JoanVilarino.Demos.ExplicitInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("************* IMPLICIT TEST ************");
            Console.WriteLine();

            Console.Write("Input value for implicit test: ");
            var value = Console.ReadLine();
            var implicitObj = new ImplicitChildClass(value);

            if (implicitObj.TestIsEmpty())
                Console.WriteLine(string.Format("The Value is empty."));
            else
            {
                // The interface is implicitly implemented on the parent class, so it's 
                // accesible directly from the object...
                Console.WriteLine(string.Format("The value your typed is: {0}", implicitObj.TestMethod()));
            }

            Console.WriteLine();
            Console.WriteLine("************* EXPLICIT TEST ************");
            Console.WriteLine();

            Console.Write("Input value for explicit test ");
            value = Console.ReadLine();
            var explicitObj = new ExplicitChildClass(value);

            if (explicitObj.TestIsEmpty())
                Console.WriteLine(string.Format("Value is empty: {0}",explicitObj.TestIsEmpty()));
            else
            {
                // Here's the real deal, you can't do explicitObj.TestMethod(), since
                // the interface's method is not implemented as member of the class, so we 
                // instantiate it as ITest to access the Explicit interface method.
                ITest interfaceInstanced = explicitObj;
                Console.WriteLine(string.Format("The value your typed is: {0}", interfaceInstanced.TestMethod()));
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
