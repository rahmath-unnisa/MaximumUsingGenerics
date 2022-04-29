using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindingMaxNumber;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMaxCase3
    {
        [Test]
        public void GivenFloatInput_WhenTestMax_ShouldReturnMaximum()
        {
            MaximumNumber max = new MaximumNumber();
            float actual = max.FindMaxFloat(4.6f, 5.5f, 10.0f);
            Assert.AreEqual(actual, 10.0f);
        }


    }
}
