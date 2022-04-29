using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindingMaxNumber;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMaxCase2
    {
        [Test]
        public void GivenFloatInput_WhenTestMax_ShouldReturnMaximum()
        {
            MaximumNumber max = new MaximumNumber();
            float actual = max.FindMaxFloat(2.4f, 9.0f, 5.0f);
            Assert.AreEqual(actual, 9.0f);
        }
    }
}
