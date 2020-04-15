using NUnit.Framework;
using static TestMaximum.MaximumNumber;

namespace TestMaximum
{
    public class Tests
    {
        ///<summary>
        ///Test case for Integer maximum Number
        /// </summary>
        [Test]
        public void maximumNumberTest_toCompare_threeNumbers()
        {
            int MaximumValueOfInteger = MaximumNumber.Generic<int>.getMaximumNumber(23, 43, 45);
            Assert.AreEqual(45, MaximumValueOfInteger);
        }
        ///<summary>
        ///Test case for Floating maximum Number
        /// </summary>
        [Test]
        public void maximumDoubleTest_toCompare_threeNumbers()
        {
            double MaximumValueOfFloat = MaximumNumber.Generic<double>.getMaximumNumber(2.6, 9.5, 5.6);
            Assert.AreEqual(9.5, MaximumValueOfFloat);
        }
        ///<summary>
        ///Test case for String size maximum Number
        /// </summary>
        [Test]
        public void maximumStringTest_toCompare_threeString()
        {
            int MaximumValueOfString = MaximumNumber.Generic<int>.getMaximumNumber("The".Length, "Maximum".Length, "Number".Length);
            Assert.AreEqual(7, MaximumValueOfString);
        }
        ///<summary>
        ///print generic method to print to get maximum number
        /// </summary>
        [Test]
        public static void maximumOfTheThreeIntegerFloatAndString()
        {
            int MaximumValueOfInteger = MaximumNumber.Generic<int>.getMaximumNumber(23, 43, 45);
            double MaximumValueOfFloat = MaximumNumber.Generic<double>.getMaximumNumber(2.6, 9.5, 5.6);
            int MaximumValueOfString = MaximumNumber.Generic<int>.getMaximumNumber("The".Length, "Maximum".Length, "Number".Length);
            Assert.AreEqual(45, MaximumValueOfInteger);
            Assert.AreEqual(9.5, MaximumValueOfFloat);
            Assert.AreEqual(7, MaximumValueOfString);
        }
    }
}