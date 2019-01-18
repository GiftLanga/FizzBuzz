using NUnit.Framework;
using FizzBuzz;


namespace FizzBuzz.Test
{
    class FizzBuzzTest
    {
        FizzBuzzClass FZ;

        public FizzBuzzTest()
        {
            FZ = new FizzBuzzClass();
        }

        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(27, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(11, "Whizz")]
        [TestCase(5, "Buzz")]
        [TestCase(7, "Whizz")]
        [TestCase(1, "1")]
        [TestCase(4, "4")]
        [TestCase(73, "Whizz")]
        [TestCase(2, "Whizz")]

        public void givenNumber_Outcome(int number, string Outcome)
        {
            var result = FZ.isDivisible(number);
            Assert.AreEqual(Outcome, result);
        }
    }
}
