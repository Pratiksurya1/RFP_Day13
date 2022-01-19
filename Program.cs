using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_GenericsMinAndMax
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            TestCase testCase = new TestCase();

            Console.WriteLine(CompareThreeNumber.MaxintNum(10.12F, 35.15F, 20.6F));
        }
    }
}
