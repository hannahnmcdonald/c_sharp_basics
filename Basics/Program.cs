using Basics.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World!! This is my first C# Application";

            Console.WriteLine(message);

            var john = new Person();
            john.FirstName = "John";
            john.LastName = " Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
