using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_GenericsMinAndMax
{
    internal class TestCase
    {
        int firstInt = 30;
        int secondInt = 20;
        public void TestMinAndMax()
        {
            if (firstInt.CompareTo(secondInt) < 0)
                Console.WriteLine("second value is greater");

            else if (firstInt.CompareTo(secondInt) > 0)
                Console.WriteLine("First value in greater");

            else if(firstInt.CompareTo(secondInt) == 0)
                Console.WriteLine("Two value Equls");
        }
    }
}
