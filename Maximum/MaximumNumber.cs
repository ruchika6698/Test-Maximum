using System;
using System.Linq;

namespace TestMaximum
{
    public class MaximumNumber
    {
        ///<summary>
        ///Main Method
        /// </summary>
        //Main Class
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Find Maximum Number Problems Using Generics..!!");
            FindMaximumNumber<int>.testMaximum(1, 2, 3);
            FindMaximumNumber<float>.testMaximum(1.00f, 2.10f, 3.5f);
            FindMaximumNumber<int>.testMaximum("sunil".Length, "anurag".Length, "abhijit".Length);
        }
    }
    ///<summary>
    ///Create generic class
    /// </summary>
    public class FindMaximumNumber<AnyDataType>
    {
        AnyDataType variable1;
        AnyDataType variable2;
        AnyDataType variable3;
        public FindMaximumNumber(AnyDataType variable1, AnyDataType variable2, AnyDataType variable3)
        {
            this.variable1 = variable1;
            this.variable2 = variable2;
            this.variable3 = variable3;
        }
        public AnyDataType testMaximum()
        {
            return testMaximum(variable1, variable2, variable3);
        }

        public static AnyDataType testMaximum(AnyDataType variable1, AnyDataType variable2, AnyDataType variable3)
        {
            AnyDataType[] array = { variable1, variable2, variable3 };
            //Find The Maximum Number In Array
            AnyDataType maximumValue = array.Max();
            Console.WriteLine(maximumValue);
            return maximumValue;
        }
    }
}
