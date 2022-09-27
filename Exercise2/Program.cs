using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Exercise2
{
    internal class Program
    {
        public static float Add(float[] numberArray)
        {
            var total = numberArray[0];
            foreach (var number in numberArray.Skip(1))
            {
                total += number;
            }

            return total;
        }
        public static float Sub(float[] numberArray)
        {
            var total = numberArray[0];
            foreach (var number in numberArray.Skip(1))
            {
                total -= number;
            }

            return total;
        }
        public static float Pro(float[] numberArray)
        {
            var total = numberArray[0];
            foreach (var number in numberArray.Skip(1))
            {
                total *= number;
            }

            return total;
        }
        public static float Quo(float[] numberArray)
        {
            var total = numberArray[0];
            foreach (var number in numberArray.Skip(1))
            {
                total /= number;
            }

            return total;
        }

        // Driver Code	
        static void Main(string[] args)
        {
            Console.WriteLine("Type a list of any length of numbers to add, subtract, multiply, and divide them all" +
                " in sequential order." +
            "\ni.e. 1, 2, 3, 4, 5");

            var numbers = Console.ReadLine();

            var numberArray = numbers
                .Split(",")
                .Select(x => float.Parse(x))
                .ToArray();

            var sum = Add(numberArray);
            var difference = Sub(numberArray);
            var product = Pro(numberArray);
            var quotient = Quo(numberArray);

            // Displaying result
            Console.WriteLine($"Sum of given sequence:\n       {sum}");
            Console.WriteLine($"Difference of given sequence:\n       {difference}");
            Console.WriteLine($"Product of given sequence:\n       {product}");
            Console.WriteLine($"Quotient of given sequence:\n       {quotient}");
        }
    }
}