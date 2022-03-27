using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program_part_1
{
    internal class Reversenumber
    {
        public void Reverse()
        {
            Console.WriteLine("Welcome to Reverse Number");
            Console.WriteLine("Please Enter a Number To check Reverese Number: ");
            int num = int.Parse(Console.ReadLine());
            int temp, rem, rev = 0;
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                rev = ((rev * 10) + rem);
                num = num / 10;
            }

            Console.WriteLine("Reverse of the number " + temp + " is: " + rev);
            Console.ReadLine();
        }


    }
}
