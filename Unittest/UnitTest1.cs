using System.Collections.Generic;
using Xunit;
using System;
using Andrzej;

namespace Unittest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var object1 = new Multi();
            List<int> listTestNumbers = new List<int>() { 2, 3, 4, 5, 9, 15,90 };
            
            Assert.Collection(listTestNumbers,
                item => Assert.NotEqual("Fizz", object1.FizzBuzzNumbers(item)),
                item => Assert.Equal("Fizz", object1.FizzBuzzNumbers(item)),
                item => Assert.Equal("4", object1.FizzBuzzNumbers(item)),
                item => Assert.Equal("Buzz", object1.FizzBuzzNumbers(item)),
                item => Assert.NotEqual("Buzz", object1.FizzBuzzNumbers(item)),
                item => Assert.Equal("FizzBuzz", object1.FizzBuzzNumbers(item)),
                item => Assert.Equal("FizzBuzz", object1.FizzBuzzNumbers(item))
            );
        }
    }
}