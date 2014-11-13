using System;
using System.ComponentModel;
using JoanVilarino.Demos.ExplicitInterfaceDemo.Tests;

namespace JoanVilarino.Demos.ExplicitInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            DisambiguationTest.Run();

            OcultationTest.Run();

            InheritanceTest.Run();

        }
    }
}
