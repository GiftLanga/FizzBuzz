using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzClass
    {
        public enum Outcome
        {
            Fizz,
            Buzz,
            FizzBuzz
        }
        public FizzBuzzClass()
        {

        }

        public string isDivisible(int number)
        {
            if(isDivisiblebyBoth3and5(number))
            {
                return "FizzBuzz";
            }
            else if(isDivisibleby3(number))
            {
                return "Fizz";
            }
            else if (isDivisibleby5(number))
            {
                return "Buzz";
            } else if (isPrime(number))
            {
                return "Whizz";
            }
            
            return number.ToString();
        }

        public bool isDivisiblebyBoth3and5(int number) {
            return isDivisibleby3(number) && isDivisibleby5(number);
        }

        public bool isDivisibleby3(int number) {
            return number % 3 == 0;
        }

        public bool isDivisibleby5(int number) {
            return number % 5 == 0;
        }

        public bool isPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number%i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
