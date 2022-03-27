using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program_part_1
{
    internal class PerfectNumber
    {
        public void Perfect()
        {
            Console.WriteLine("Welcome to Perfact Number");
            int temp, sum = 0;
            Console.Write("Please Enter the Number : ");
            int num = int.Parse(Console.ReadLine());
            temp = num;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == temp)
            {
                Console.WriteLine("Entered number " + num + " is a perfect number");
            }
            else
            {
                Console.WriteLine("Entered number is not a perfect number");
            }
            Console.ReadLine();
            
        }
    }
}
