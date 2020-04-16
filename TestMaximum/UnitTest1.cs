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
            Generic<int> MaximumValueOfInteger = new Generic<int>(23, 43, 45);
            Assert.AreEqual(45, MaximumValueOfInteger.result);
        }
        ///<summary>
        ///Test case for Floating maximum Number
        /// </summary>
        [Test]
        public void maximumDoubleTest_toCompare_threeNumbers()
        {
            Generic<float> MaximumValueOfFloat = new Generic<float>(2.6f, 9.5f, 5.6f);
            Assert.AreEqual(9.5, MaximumValueOfFloat.result);
        }
        ///<summary>
        ///Test case for String size maximum Number
        /// </summary>
        [Test]
        public void maximumStringTest_toCompare_threeString()
        {
            Generic<int> MaximumValueOfString = new Generic<int>("The".Length, "Maximum".Length, "Number".Length);
            Assert.AreEqual(7, MaximumValueOfString.result);
        }
        ///<summary>
        ///print generic method to print to get maximum number
        /// </summary>
        [Test]
        public static void maximumOfTheThreeIntegerFloatAndString()
        {
            Generic<int> MaximumValueOfInteger = new Generic<int>(23, 43, 45);
            Generic<float> MaximumValueOfFloat = new Generic<float>(2.6f, 9.5f, 5.6f);
            Generic<int> MaximumValueOfString = new Generic<int>("The".Length, "Maximum".Length, "Number".Length);
            Assert.AreEqual(45, MaximumValueOfInteger.result);
            Assert.AreEqual(9.5, MaximumValueOfFloat.result);
            Assert.AreEqual(7, MaximumValueOfString.result);
        }
    }
}