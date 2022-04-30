using FindingMaxNumber;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMaxCase
    {
        [Test]
        public void GivenGenericsIntInput_WhenTestMax_ShouldReturnMaximum()
        {
            MaximumNumber<int> max = new MaximumNumber<int>(1, 2, 3);
            int actual = max.FindMax();
            Assert.AreEqual(actual, 3);
        }
        [Test]
        public void GivenGenericsfloatInput_WhenTestMax_ShouldReturnMaximum()
        {
            MaximumNumber<double> max = new MaximumNumber<double>(2.3, 4.5, 6.7);
            double actual = max.FindMax();
            Assert.AreEqual(actual, 6.7);
        }
        [Test]
        public void GivenGenericsstringInput_WhenTestMax_ShouldReturnMaximum()
        {
            MaximumNumber<string> max = new MaximumNumber<string>("Apple", "Peach", "Banana");
            string actual = max.FindMax();
            Assert.AreEqual(actual, "Peach");
        }
    }
}