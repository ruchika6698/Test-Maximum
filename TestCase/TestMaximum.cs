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

    }
}
