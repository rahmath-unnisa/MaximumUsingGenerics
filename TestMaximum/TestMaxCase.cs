using FindingMaxNumber;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMaxCase
    {
        [Test]
        public void GivenGenericsIntInput_WhenTestMax_ShouldReturnMaximum()
        {
            int[] arr = { 278, 347, 432, 563, 786 };
            MaximumNumber<int> max = new MaximumNumber<int>(arr);
            int actual = max.PrintMaxMethod();
            Assert.AreEqual(actual, 786);
        }
        [Test]
        public void GivenGenericsfloatInput_WhenTestMax_ShouldReturnMaximum()
        {
            float[] arr = { 1.4f, 4.2f, 1.1f, 7.2f, 9.8f };
            MaximumNumber<float> max = new MaximumNumber<float>(arr);
            float actual = max.PrintMaxMethod();
            Assert.AreEqual(actual, 9.8f);
        }
        [Test]
        public void GivenGenericsstringInput_WhenTestMax_ShouldReturnMaximum()
        {
            string[] arr = { "Apple", "Peach", "Banana", "Orange", "Papaya" };
            MaximumNumber<string> max = new MaximumNumber<string>(arr);
            string actual = max.PrintMaxMethod();
            Assert.AreEqual(actual, "Papaya");
        }
    }
}