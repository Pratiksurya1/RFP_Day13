using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_GenericsMinAndMax
{
    internal class CompareThreeNumber<T> where T : IComparable
    {
        public static T MaxintNum(T firstNum,T secondNum,T therdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(therdNum) > 0 ||
                firstNum.CompareTo(secondNum) >= 0 && firstNum.CompareTo(therdNum) > 0 ||
                firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(therdNum) >= 0)
                return firstNum;

            else if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(therdNum) > 0 ||
                     secondNum.CompareTo(firstNum) >= 0 && secondNum.CompareTo(therdNum) > 0 ||
                     secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(therdNum) >= 0)
                return secondNum;

            else if (therdNum.CompareTo(secondNum) > 0 && therdNum.CompareTo(firstNum) > 0 ||
                     therdNum.CompareTo(secondNum) >= 0 && therdNum.CompareTo(firstNum) > 0 ||
                     therdNum.CompareTo(secondNum) > 0 && therdNum.CompareTo(firstNum) >= 0)
                return therdNum;
            else
                return firstNum; 

        }

        //using method overloadin tak four parameters 
        public static T MaxintNum(T firstNum, T secondNum, T therdNum, T fourthNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(therdNum) > 0 && firstNum.CompareTo(fourthNum)>0 ||
               firstNum.CompareTo(secondNum) >= 0 && firstNum.CompareTo(therdNum) > 0 && firstNum.CompareTo(fourthNum) > 0 ||
               firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(therdNum) >= 0 && firstNum.CompareTo(fourthNum) > 0)
                return firstNum;

            else if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(therdNum) > 0 && secondNum.CompareTo(fourthNum) > 0 ||
                     secondNum.CompareTo(firstNum) >= 0 && secondNum.CompareTo(therdNum) > 0 && secondNum.CompareTo(fourthNum) > 0 ||
                     secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(therdNum) >= 0 && secondNum.CompareTo(fourthNum) > 0)
                return secondNum;

            else if (therdNum.CompareTo(secondNum) > 0 && therdNum.CompareTo(firstNum) > 0 && therdNum.CompareTo(fourthNum) > 0 ||
                     therdNum.CompareTo(secondNum) >= 0 && therdNum.CompareTo(firstNum) > 0 && therdNum.CompareTo(fourthNum) > 0 ||
                     therdNum.CompareTo(secondNum) > 0 && therdNum.CompareTo(firstNum) >= 0 && therdNum.CompareTo(fourthNum) > 0)
                return therdNum;

            else if (fourthNum.CompareTo(secondNum) > 0 && fourthNum.CompareTo(firstNum) > 0 && fourthNum.CompareTo(fourthNum) > 0 ||
                     fourthNum.CompareTo(secondNum) >= 0 && fourthNum.CompareTo(firstNum) > 0 && fourthNum.CompareTo(fourthNum) > 0 ||
                     fourthNum.CompareTo(secondNum) > 0 && fourthNum.CompareTo(firstNum) >= 0 && fourthNum.CompareTo(fourthNum) > 0)
                return fourthNum;
            else
                return firstNum;
        }
    }
}
