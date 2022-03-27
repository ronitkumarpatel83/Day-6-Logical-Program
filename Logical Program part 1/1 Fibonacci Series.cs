using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program_part_1
{
    internal class Fibonacci
    {
        public void Fibo()
        {
            Console.WriteLine("Welcome to Fibonacci Series");

            int a = 0, b = 1, value, i, number;

            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(a + " " + b + " ");
            for (i = 2; i < number; ++i)
            {
                value = a + b;
                Console.Write(value + " ");
                a = b;
                b = value;
            }
           Console.ReadLine();
        }
        
    }
}
