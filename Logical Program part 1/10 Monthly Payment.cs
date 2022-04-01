using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program_part_1
{
    internal class MonthlyPayment
    {
        public void Payment()
        {
            double PrincipleAmount, Year, Rate, n, r, monthPayAmount;
            Console.WriteLine("\nEnter Principal Loan Amount : ");
            PrincipleAmount = Convert.ToDouble(Console.ReadLine()); // Reads the total Loan Number
            Console.WriteLine("\nHow many years to pay off Principle Amount : ");
            Year = Convert.ToDouble(Console.ReadLine());  // Reads the year
            Console.WriteLine("\nEnter rate of interest per year : ");
            Rate = Convert.ToDouble(Console.ReadLine()); // Reads th rate
            //Applying formula to calculate the monthly payment
            n = 12 * Year;
            r = Rate / (12 * 100);
            monthPayAmount = (PrincipleAmount * r) / (1 - Math.Pow(1 + r, -n));
            Console.WriteLine($"\nMonthly Payment you have to pay off {PrincipleAmount} Loan Amount over {Year} years is : {monthPayAmount}");
        }
    }
}
