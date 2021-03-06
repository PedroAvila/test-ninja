using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        //private Math _math;

        //public void SetUp()
        //{
        //    _math = new Math();
        //}



        [Test]
        //[Ignore("Because I wanted to!")]
        public void AddWhenCalled_ReturnTheSumOfArguments()
        {
            var math = new Math();
            var result = math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
            
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var math = new Math();
            var result = math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        //[Test]
        //public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        //{
        //    var result = _math.Max(1, 2);
        //    Assert.That(result, Is.EqualTo(2));
        //}

        //[Test]
        //public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        //{
        //    var result = _math.Max(1, 1);
        //    Assert.That(result, Is.EqualTo(1));
        //}

    }
}
