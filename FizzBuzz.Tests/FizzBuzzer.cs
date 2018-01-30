using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{
    class FizzBuzzer
    {
        //public string Get(int number)
        //{
        //    return number.ToString();
        //}

        public string Get(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }
           
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            return number.ToString();

        }






    }
}
