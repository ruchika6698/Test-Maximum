using NUnit.Framework;
using Test_Maximum;

namespace Test_Maximum.TestCase
{
    [TestFixture]
    class TestMaximum
    {
        [Test]
        public void Max_ReturnsExpectedValue()
        {
            MaximumNumber md = new MaximumNumber();
            int actualMax = md.maximumInteger(100, 225, 14);
            Assert.AreEqual(225, actualMax);
        }

        [Test]
        public void Max_ReturnsExpectedValue1()
        {
            MaximumNumber md = new MaximumNumber();
            double actualMax = md.doubleArray(10.5, 15.2, 14.3);
            Assert.AreEqual(15.2, actualMax);
        }
    }
}
