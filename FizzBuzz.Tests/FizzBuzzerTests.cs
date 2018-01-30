using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{

    [TestFixture]
    public class FizzBuzzerTests
    {
        //[Test]
        //public void Get_Returns_A_Number()
        //{
        //    var fizzBuzzer = new FizzBuzzer();

        //    var result = fizzBuzzer.Get(2);

        //    Assert.That(result, Is.EqualTo("2"));
        //}


        //[Test]
        //public void Get_Return_A_Number_For_4()
        //{
        //    var fizzBuzzer = new FizzBuzzer();

        //    var result = fizzBuzzer.Get(4);

        //    Assert.That(result, Is.EqualTo("Fizz"));
        //}

        [Test]
        public void Get_Returns_Buzz_For_5()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }









    }
}
