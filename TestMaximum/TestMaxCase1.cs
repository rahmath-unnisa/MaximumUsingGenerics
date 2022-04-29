using FindingMaxNumber;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMaxCase1
    {
        [Test]
        public void GivenStringInput_WhenTestMax_ShouldReturnMaximum()
        {
            MaximumNumber max = new MaximumNumber();
            string actual = max.FindMaxString("Peach", "Banana", "Apple");
            Assert.AreEqual(actual, "Peach");
        }
    }
}