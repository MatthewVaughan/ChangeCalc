using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Lab 21
// Date: 03/24/2016 09:15:19 am
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Lab21
{
    class Program
    {
        // some  class level constants
        const int HALVES = 50;
        const int QUARTERS = 25;
        const int DIMES = 10;
        const int NICKELS = 5;
        const int PENNIES = 1;

        static void Main()
        {
            int money;// the value we want to count change for

            Console.WriteLine("I will make change for you.");
            Console.Write("Enter in an amount between 1 and 99: ");
            money = int.Parse(Console.ReadLine());

            Console.WriteLine($"For {money} you get:");

            Console.WriteLine("{0} halves", ComputeChange(ref money, HALVES));
            Console.WriteLine("{0} quarters", ComputeChange(ref money, QUARTERS));
            Console.WriteLine("{0} dimes", ComputeChange(ref money, DIMES));
            Console.WriteLine("{0} nickels", ComputeChange(ref money, NICKELS));
            Console.WriteLine("{0} pennies\n", ComputeChange(ref money, PENNIES));
            Console.ReadLine();
        }

        // The ComputeChange Method
        // Add your method prologue here
        static int ComputeChange(ref int changeValue, int coinValue)
        {
            //declare a variable
            int numCoin = 0;

            //Find the number of coins it would take
            numCoin = changeValue / coinValue;

            //Change the value or how much money is left by modulus
            changeValue = changeValue % coinValue;

            //Return the number of coin value
            return numCoin;
        }
    }
}