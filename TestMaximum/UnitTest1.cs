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
        public void givenTheNumbers_whenIntegerDatatype_returnmaximumNumber()
        {
            Generic<int> MaximumValueOfInteger = new Generic<int>(23, 43, 45);
            Assert.AreEqual(45, MaximumValueOfInteger.result);
        }
        ///<summary>
        ///Test case for Floating maximum Number
        /// </summary>
        [Test]
        public void givenTheNumbers_whenFloatDatatype_returnmaximumNumber()
        {
            Generic<float> MaximumValueOfFloat = new Generic<float>(2.6f, 9.5f, 5.6f);
            Assert.AreEqual(9.5, MaximumValueOfFloat.result);
        }
        ///<summary>
        ///Test case for String size maximum Number
        /// </summary>
        [Test]
        public void givenTheNumbers_whenstringDatatype_returnmaximumsizeofstring()
        {
            Generic<int> MaximumValueOfString = new Generic<int>("The".Length, "Maximum".Length, "Number".Length);
            Assert.AreEqual(7, MaximumValueOfString.result);
        }
        ///<summary>
        ///print generic method to print to get maximum number
        /// </summary>
        [Test]
        public static void givenTheNumbers_whenallDatatype_returntestmaximum()
        {
            Generic<int> MaximumValueOfInteger = new Generic<int>(23, 43, 45);
            Generic<float> MaximumValueOfFloat = new Generic<float>(2.6f, 9.5f, 5.6f);
            Generic<int> MaximumValueOfString = new Generic<int>("The".Length, "Maximum".Length, "Number".Length);
            Assert.AreEqual(45, MaximumValueOfInteger.result);
            Assert.AreEqual(9.5f, MaximumValueOfFloat.result);
            Assert.AreEqual(7, MaximumValueOfString.result);
        }
        ///<summary>
        ///test case for More than three parameters and find the maximum number
        /// </summary>
        [Test]
        public void givenmorethanthreeNumbers_whenallDatatype_returntestmaximum()
        {
            GenericCheck<int> obj1 = new GenericCheck<int>();
            GenericCheck<double> obj2 = new GenericCheck<double>();
            GenericCheck<int> obj3 = new GenericCheck<int>();
            int[] Number1 = { 23, 43, 45, 55, 98, 60 };
            double[] Number2 = { 0.5, 11.2, 20.9, 30.4, 70.8, 1.8 };
            int[] Number3 = { "The".Length, "Maximum".Length, "Number".Length, "Problem".Length, "using".Length, "Generics".Length };
            int result1 = (obj1.Max(Number1));
            double result2 = (obj2.Max(Number2));
            int result3 = (obj3.Max(Number3));
            Assert.AreEqual(98, result1);
            Assert.AreEqual(70.8, result2);
            Assert.AreEqual(8, result3);
        }
    }
}