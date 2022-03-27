using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program_part_1
{
    internal class CouponNumber
    {
        public void Coupon()
        {
            Console.WriteLine("Welcome to Coupon Number");

            Console.WriteLine("Please Enter how many Random distinct number you want: ");
            int num = int.Parse(Console.ReadLine());
            int[] ran = new int[num];

            Console.WriteLine("Enter the Starting range of Random Number you want");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the ending range of Random numnber you want ");
            int end = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Random random = new Random();
                int n = random.Next(start, end);
                ran[i] = n;
            }
            Console.WriteLine("All Random Distinct Numbers are: ");
            foreach (int j in ran)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();
        }
    }
}
