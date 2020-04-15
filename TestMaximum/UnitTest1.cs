using NUnit.Framework;

namespace TestMaximum
{
    public class Tests
    {
        ///<summary>
        ///Test case for Integer maximum Number
        /// </summary>
        [Test]
        public static void maximumOfTheThreeIntegerNumbers()
        {
            int MaximumValue = FindMaximumNumber<int>.testMaximum(3, 4, 5);
            Assert.AreEqual(5, MaximumValue);
        }
        ///<summary>
        ///Test case for Floating maximum Number
        /// </summary>
        [Test]
        public static void maximumOfTheThreeFloatNumbers()
        {
            float MaximumValue = FindMaximumNumber<float>.testMaximum(1.01f, 5.02f, 4.10f);
            Assert.AreEqual(5.02f, MaximumValue);
        }
        ///<summary>
        ///Test case for String size maximum Number
        /// </summary>
        [Test]
        public static void maximumOfTheThreeStringElement()
        {
            MaximumNumber value = new MaximumNumber();
            int MaximumValue = FindMaximumNumber<int>.testMaximum("The".Length, "Maximum".Length, "Number".Length);
            Assert.AreEqual(7, MaximumValue);
        }
        ///<summary>
        ///Test case for Print Maximum Number
        /// </summary>
        [Test]
        public static void maximumOfTheThreeIntegerFloatAndString()
        {
            int MaximumValueOfInteger = FindMaximumNumber<int>.testMaximum(3, 4, 5);
            float MaximumValueOfFloat = FindMaximumNumber<float>.testMaximum(1.01f, 5.02f, 4.10f);
            int MaximumValueOfString = FindMaximumNumber<int>.testMaximum("The".Length, "Maximum".Length, "Number".Length);
            Assert.AreEqual(5, MaximumValueOfInteger);
            Assert.AreEqual(5.02f, MaximumValueOfFloat);
            Assert.AreEqual(7, MaximumValueOfString);

        }
    }
}