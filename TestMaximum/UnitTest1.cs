using NUnit.Framework;

namespace MaximumGeneric
{
    [TestFixture]
    public class Tests
    {
        ///<summary>
        ///Test case for Integer maximum Number
        /// </summary>
        [Test]
        public void Max_ReturnIntegerValue()
        {
            int actualMaxInteger = MaximumNumber.MaximumValue<int>.maxValueArray(100, 15, 154);
            Assert.AreEqual(154, actualMaxInteger);
        }

        ///<summary>
        ///Test case for Floating maximum Number
        /// </summary>
        [Test]
        public void Max_ReturnFloatValue()
        {
            float actualMaxFloat = MaximumNumber.MaximumValue<float>.maxValueArray(10, 15, 14);
            Assert.AreEqual(15, actualMaxFloat);
        }

        ///<summary>
        ///Test case for String size maximum Number
        /// </summary>
        [Test]
        public void Max_ReturnStringValue()
        {
            int actualMaxString = MaximumNumber.MaximumValue<string>.maxValueArray("Test".Length, "Maximum".Length, "Number".Length);
            Assert.AreEqual(7, actualMaxString);
        }
    }
}