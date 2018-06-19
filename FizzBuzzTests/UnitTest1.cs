using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Setup()
        {

        }

        [TestMethod]
        public void Expect_No_Is_Divisible_by_3()
        {
            Assert.AreEqual(Program.IsDivisibleBy3(3), true);
            Assert.AreEqual(Program.IsDivisibleBy3(6), true);
            Assert.AreEqual(Program.IsDivisibleBy3(9), true);
            Assert.AreEqual(Program.IsDivisibleBy3(15), true);
            Assert.AreEqual(Program.IsDivisibleBy3(18), true);
            Assert.AreEqual(Program.IsDivisibleBy3(21), true);
        }

        [TestMethod]
        public void Expect_No_Is_Not_Divisible_by_3()
        {
            Assert.AreEqual(Program.IsDivisibleBy3(5), false);
            Assert.AreEqual(Program.IsDivisibleBy3(4), false);
            Assert.AreEqual(Program.IsDivisibleBy3(10), false);
            Assert.AreEqual(Program.IsDivisibleBy3(19), false);
            Assert.AreEqual(Program.IsDivisibleBy3(20), false);
        }

        [TestMethod]

        public void Expect_No_Is_Divisible_by_5()
        {
            Assert.AreEqual(Program.IsDivisibleBy5(5), true);
            Assert.AreEqual(Program.IsDivisibleBy5(10), true);
            Assert.AreEqual(Program.IsDivisibleBy5(15), true);
        }

        [TestMethod]

        public void Expect_No_Is_Divisible_by_15()
        {
            Assert.AreEqual(Program.IsDivisibleBy15(15), true);
            Assert.AreEqual(Program.IsDivisibleBy15(30), true);
            Assert.AreEqual(Program.IsDivisibleBy15(45), true);
        }

        [TestMethod]

        public void Expect_No_Is_Not_Divisible_by_5()
        {
            Assert.AreEqual(Program.IsDivisibleBy5(4), false);
            Assert.AreEqual(Program.IsDivisibleBy5(8), false);
            Assert.AreEqual(Program.IsDivisibleBy5(12), false);
        }

        [TestMethod]
        public void Expect_No_Is_Not_Divisible_by_15()
        {
            Assert.AreEqual(Program.IsDivisibleBy15(4), false);
            Assert.AreEqual(Program.IsDivisibleBy15(8), false);
            Assert.AreEqual(Program.IsDivisibleBy15(12), false);
        }

        [TestMethod]
        public void Expect_FizzBuzz_Return_The_Number()
        {
            Assert.AreEqual(Program.FizzBuzz(1), "1");
        }

        [TestMethod]
        public void Expect_FizzBuzz_Return_negative()
        {
            Assert.AreEqual(Program.FizzBuzz(0), 0);
        }

        [TestMethod]
        public void Expect_FizzBuzz_Return_The_Fizz()
        {
            Assert.AreEqual(Program.FizzBuzz(3), "Fizz");
        }

        [TestMethod]
        public void Expect_FizzBuzz_Return_The_Buzz()
        {
            Assert.AreEqual(Program.FizzBuzz(5), "Buzz");
        }

        [TestMethod]
        public void Expect_FizzBuzz_Return_The_FizzBuzz()
        {
            Assert.AreEqual(Program.FizzBuzz(15), "FizzBuzz");
        }

        [TestMethod]
        public void Test_Multiples_Of_Three_But_Not_Five_Are_Fizz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && !(i % 5 == 0))
                {
                    Assert.AreEqual(Program.FizzBuzz(i), "Fizz");
                }
            }
        }

        [TestMethod]
        public void Test_Multiples_Of_Five_But_Not_Three_Are_Buzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (!(i % 3 == 0) && (i % 5 == 0))
                {
                    Assert.AreEqual(Program.FizzBuzz(i), "Buzz");
                }
            }
        }

        [TestMethod]
        public void Test_Multiples_Of_Three_And_Five_Are_FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Assert.AreEqual(Program.FizzBuzz(i), "FizzBuzz");
                }
            } 
        }

        [TestMethod]
        public void Test_Not_Multiples_Of_Three_And_Five_Are_FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (!(i % 3 == 0) && !(i % 5 == 0))
                {
                    Assert.AreEqual(Program.FizzBuzz(i), i.ToString());
                }
            }
        }

    }
}
