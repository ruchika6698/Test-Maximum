using System;
using System.Linq;

namespace TestMaximum
{
    public class MaximumNumber
    {
        ///<summary>
        ///Main Method
        /// </summary>
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum Problem");
        }
        ///<summary>
        ///GENERIC CLASS
        /// </summary>
        public class Generic<AnydataType> where AnydataType : IComparable
        {
            //encapsulate Data
            public AnydataType result;
            private AnydataType data1;
            private AnydataType data2;
            private AnydataType data3;
          

            public Generic(AnydataType variable1, AnydataType variable2, AnydataType variable3)
            {
                data1 = variable1;
                data2 = variable2;
                data3 = variable3;
                result = testMaximum(data1, data2, data3);
            }

            public AnydataType testMaximum(AnydataType data1, AnydataType data2, AnydataType data3)
            {

                if (data1.CompareTo(data2) > 0 && data1.CompareTo(data3) > 0)
                {
                    return printMaximum(data1);
                }
                else if (data2.CompareTo(data1) > 0 && data2.CompareTo(data3) > 0)
                {
                    return printMaximum(data2);
                }
                else
                {
                    return printMaximum(data3);
                }
            }
            public AnydataType printMaximum(AnydataType max)
            {
                Console.WriteLine("max value = " + max);
                return max;
            }
        }
        /// <summary>
        /// Generic Class create to check for more than 3 
        /// </summary>
        public class GenericCheck<anyDataType>
        {
            public anyDataType Max(anyDataType[] values)
            {
                anyDataType[] Numbers = new anyDataType[values.Length];
                for (int index = 0; index < values.Length; index++)
                {
                    Numbers[index] = values[index];
                }
                anyDataType MaximumValue = Numbers.Max();
                return MaximumValue;
            }
        }
    }
}

