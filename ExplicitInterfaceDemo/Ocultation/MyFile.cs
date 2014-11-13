using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoanVilarino.Demos.ExplicitInterfaceDemo.Ocultation
{

    class MyFile : IDisposable
    {
        public MyFile()
        {
            Console.WriteLine("Instantiating the object...");
        }

        void IDisposable.Dispose()
        {
            Console.WriteLine("Disposing the object...");
            Close();
        }

        public void Close()
        {
            // Do what's necessary to close the file
            System.GC.SuppressFinalize(this);
        }
    }
}
