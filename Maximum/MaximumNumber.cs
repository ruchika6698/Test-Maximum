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
        public class Generic<T> where T : IComparable
        {
            public T result;
            private T data1;
            private T data2;
            private T data3;
            private T temp;

            public Generic(T variable1, T variable2, T variable3)
            {
                data1 = variable1;
                data2 = variable2;
                data3 = variable3;
                result = testMaximum(data1, data2, data3);
            }

            public T testMaximum(T data1, T data2, T data3)
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
            public T printMaximum(T max)
            {
                Console.WriteLine("max value = " + max);
                return max;
            }
        }
        /// <summary>
        /// Generic Class createg to check for more than 3 Data Entry
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

