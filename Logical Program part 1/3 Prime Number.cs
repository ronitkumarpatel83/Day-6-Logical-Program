using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program_part_1
{
    internal class PrimeNumber
    {
        public void Prime()
        {
            Console.WriteLine("Welcome to Prime NUmber");
            Console.WriteLine("Enter a Number to Check prime or not: ");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Enetred Number is a prime number : " +num);
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            Console.ReadLine();
            
        }

    }
}
