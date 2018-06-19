using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class Program
    {
        public static bool IsDivisibleBy3(int number)
        {
            return IsDivisibleByNumber(number, 3);
        }

        public static bool IsDivisibleBy5(int number)
        {
            return IsDivisibleByNumber(number, 5);
        }

        public static bool IsDivisibleBy15(int number)
        {
            return IsDivisibleByNumber(number, 15);
        }

        public static bool IsDivisibleByNumber(int number, int divisor)
        {
            return number % divisor == 0;
        }

        public static string FizzBuzz(int number)
        {
            if (IsDivisibleBy15(number))
                return "FizzBuzz";
            if (IsDivisibleBy5(number))
                return "Buzz";
            if (IsDivisibleBy3(number))
                return "Fizz";
            return number.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

    }
}
