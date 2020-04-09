using System;

namespace Test_Maximum
{
    class MaximumNumber
    {
        public int maximumInteger(int firstValue, int secondValue, int thirdValue)
        {
            if(firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Test Maximum Number");
            MaximumNumber maximuminteger = new MaximumNumber();
        }
    }
}
