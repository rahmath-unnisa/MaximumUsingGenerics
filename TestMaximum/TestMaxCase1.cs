using FindingMaxNumber;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMaxCase1
    {
        [Test]
        public void GivenFloatInput_WhenTestMax_ShouldReturnMaximum()
        {
            MaximumNumber max = new MaximumNumber();
            float actual = max.FindMaxFloat(8.0f,3.5f,5.6f);
            Assert.AreEqual(actual, 8.0f);
        }
    }
}