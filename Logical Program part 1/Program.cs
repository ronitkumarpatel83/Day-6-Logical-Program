using System;

namespace Logical_Program_part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int n = 1;
            
            while (n == 1)
            {
                Console.WriteLine(" Welcome To Logical Program");
                Console.WriteLine("Please choose a number between 1 to 6");
                Console.WriteLine("1.Fibonacci Series\n2.Perfact Number\n3.Prime Number");
                Console.WriteLine("4.Reverse Number\n5.Coupon Number\n6.Stop Watch");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Fibonacci Series");
                        Fibonacci fibonacci = new Fibonacci();
                        fibonacci.Fibo();
                        break;
                    case 2:
                        Console.WriteLine("Perfact Number");
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.Perfect();
                        break;
                    case 3:
                        Console.WriteLine("Prime Number");
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.Prime();
                        break;
                    case 4:
                        Console.WriteLine("Reverse Number");
                        Reversenumber reverseNumber = new Reversenumber();
                        reverseNumber.Reverse();
                        break;
                    case 5:
                        Console.WriteLine("Coupon Number");
                        CouponNumber couponNumber = new CouponNumber();
                        couponNumber.Coupon();
                        break;
                    case 6:
                        Console.WriteLine("Simulator Stop Watch");
                        SimulateStopWatch simulateStopWatch = new SimulateStopWatch();
                        simulateStopWatch.StopWatch();
                        break;

                    default:
                        Console.WriteLine("Enter a Valid Number");
                        break;
                }
                Console.WriteLine("\n Press 1 to Continue or Press any other key to Exit");
                n = Convert.ToInt32(Console.ReadLine());

            }

            
        }
    }
}
