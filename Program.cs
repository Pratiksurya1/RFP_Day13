﻿using NPOI.SS.Formula.Functions;
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

            Console.WriteLine(CompareThreeNumber<String>.MaxintNum("Apple", "Peach", "Banana"));                                        //CompareThreeNumber.MaxintNum("Apple", "Peach", "Banana"));
        }
    }
}
