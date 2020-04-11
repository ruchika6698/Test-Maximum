using NUnit.Framework;

namespace MaximumGeneric
{
    public class Tests
    {
        [Test]
        public void integerMaximum()
        {
            int result = MaximumNumber.GenericClass<int>.testMaximum(1, 3, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void floatMaximum()
        {
            float result = MaximumNumber.GenericClass<float>.testMaximum(1.1f, 3.2f, 2.2f);
            Assert.AreEqual(3.2f, result);
        }

        [Test]
        public void stringMaximum()
        {
            int result = MaximumNumber.GenericClass<int>.testMaximum("Test".Length, "Maximum".Length, "Number".Length);
            Assert.AreEqual(7, result);

        }
    }
}