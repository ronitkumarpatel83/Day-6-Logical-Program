using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine("<<<<<<<<<<<< Logical Program 2 >>>>>>>>>>>>");
                Console.WriteLine(" Welcome To Logical Program 2");
                Console.WriteLine("Please choose a number between 7 to 13");
                Console.WriteLine("7.Vending Machine\n8.Day Of Week\n9.Temperature Conversion");
                Console.WriteLine("10.Monthly Payment\n11.Square Root\n12.Decimal To Binary");
                Console.WriteLine("13.Binary to Decimal");
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
                    case 7:
                        Console.WriteLine("Vending Machine");
                        VendingMachine vendingMachine = new VendingMachine();
                        vendingMachine.CountMoney();
                        break;
                    case 8:
                        Console.WriteLine("Day of Week");
                        DayOfWeek dayOfWeek = new DayOfWeek();
                        dayOfWeek.Day();
                        break;
                    case 9:
                        Console.WriteLine("Temperature Conversion");
                        TempratureConversion tempratureConversion = new TempratureConversion();
                        tempratureConversion.Conversion();
                        break;
                    case 10:
                        Console.WriteLine("Monthly Payment");
                        MonthlyPayment monthlyPayment = new MonthlyPayment();
                        monthlyPayment.Payment();
                        break;
                    case 11:
                        Console.WriteLine("Squar Root");
                        SquareRoot squareRoot = new SquareRoot();
                        squareRoot.FindSqrt();
                        break;
                    case 12:
                        Console.WriteLine("Decimal to Binary");
                        DecimalToBinary decimalToBinary = new DecimalToBinary();
                        decimalToBinary.DToBConversion();
                        break;
                    case 13:
                        Console.WriteLine("Binary to Decimal");
                        BinaryToDecimal binaryToDecimal = new BinaryToDecimal();
                        binaryToDecimal.BToDConversion();
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
