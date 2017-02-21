using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aron
{
    [TestClass]
    public class Euclidian
    {
        [TestMethod]
        public void TestMethod1()
        {
            int gcd = GreatestCommonDivisor.Calculate(10, 45);


        }
    }

    public class GreatestCommonDivisor
    {
        public static int Calculate(int firstNumber, int secondNumber)
        {            
            if (firstNumber == secondNumber) return firstNumber;

            int bigger, smaller, q, r;
            if(firstNumber> secondNumber)
            {
                bigger = firstNumber;
                smaller = secondNumber;
            }
            else
            {
                bigger = secondNumber;
                smaller = firstNumber;
            }

            do
            {
                q = bigger % smaller;
                r = bigger - smaller * q;
                bigger = smaller;
                smaller = q;
            } while (q == 0);

            return q;
        }
    }
}
