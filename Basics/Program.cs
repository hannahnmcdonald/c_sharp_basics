// Import in Calculator method
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
            // Hello World
            string message = "Hello World!! This is my first C# Application";
            Console.WriteLine(message);

            // Bring in Person method from Person.cs
            var john = new Person();
            john.FirstName = "John";
            john.LastName = " Smith";
            john.Introduce();

            // Calculator Method from Basics.Math
            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            // In C#, Arrays are fixed in size
            // Specify during declaration and unable to change
            // Can also declare what is part of the Array in declaration
            var numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            // Boolean Array
            var flags = new bool[3];

            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            // Array of Strings
            var sg1 = new string[4] { "Jack", "Sam", "Daniel", "Teal'c" };
            Console.WriteLine(sg1[0]);
            Console.WriteLine(sg1[1]);
            Console.WriteLine(sg1[2]);  
            Console.WriteLine(sg1[3]);




        }
    }
}
