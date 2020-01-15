using ConsoleApp;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PowTest()
        {
            int number = 2,
                pow = 3;
            double expected = 8.0;

            Assert.AreEqual(expected, MyMath.Pow(number, pow));
        }
    }
}