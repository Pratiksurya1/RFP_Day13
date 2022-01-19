using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_GenericsMinAndMax
{
    internal class CompareThreeNumber
    {
        public static int MaxintNum(int firstNum, int secondNum, int therdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(therdNum) > 0 ||
                firstNum.CompareTo(secondNum) >= 0 && firstNum.CompareTo(therdNum) > 0 ||
                firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(therdNum) >= 0)
                return firstNum;

            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(therdNum) > 0 ||
                secondNum.CompareTo(firstNum) >= 0 && secondNum.CompareTo(therdNum) > 0 ||
                secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(therdNum) >=0)
                return secondNum;

            if (therdNum.CompareTo(secondNum) > 0 && therdNum.CompareTo(firstNum) > 0 ||
                therdNum.CompareTo(secondNum) >= 0 && therdNum.CompareTo(firstNum) > 0 ||
                therdNum.CompareTo(secondNum) > 0 && therdNum.CompareTo(firstNum) >= 0)
                return therdNum;
            else
                return 0;
                
        }
    }
}
