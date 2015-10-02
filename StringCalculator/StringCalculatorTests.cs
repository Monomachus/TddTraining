using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    [TestFixture]
    class StringCalculatorTests
    {
        [Test]
        public void Add_WhenEmptyString_ReturnsZero()
        {
            StringCalculator stringCalculator = new StringCalculator();

            var result = stringCalculator.Add("");
            Assert.AreEqual(result, 0);
        }


    }
}
