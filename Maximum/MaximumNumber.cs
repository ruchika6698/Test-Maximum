using System;
using System.Linq;

namespace TestMaximum
{
    public class MaximumNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum Problem");
            Generic<int>.getMaximumNumber(3, 4, 5);
            Generic<double>.getMaximumNumber(3.5, 4.21, 5.5);
            Generic<int>.getMaximumNumber("The".Length, "Maximum".Length, "Number".Length);
        }

        //GENERIC CLASS
        public class Generic<T>
        {
            T variable1;
            T variable2;
            T variable3;

            //CONSTRUCTOR
            public Generic(T variable1, T variable2, T variable3)
            {
                this.variable1 = variable1;
                this.variable2 = variable2;
                this.variable3 = variable3;
            }

            //GENERIC METHODS
            public T getMaximumNumber()
            {
                return getMaximumNumber(variable1, variable2, variable3);
            }

            //GETTING MAXIMUM VALUES
            public static T getMaximumNumber(T variable1, T variable2, T variable3)
            {
                T[] arrayValue = { variable1, variable2, variable3 };
                T maxValue = arrayValue.Max();
                return maxValue;
            }
        }
    }
}
