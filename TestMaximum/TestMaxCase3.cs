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
        public void GivenStringInput_WhenTestMax_ShouldReturnMaximum()
        {
            MaximumNumber max = new MaximumNumber();
            string actual = max.FindMaxString("Apple", "Banana","Peach");
            Assert.AreEqual(actual, "Peach");
        }


    }
}
