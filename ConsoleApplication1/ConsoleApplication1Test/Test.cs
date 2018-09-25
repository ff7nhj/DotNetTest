using ConsoleApplication1;
using NUnit.Framework;

namespace ConsoleApplication1Test
{
    [TestOf(typeof(ConsoleApplication1.Utils)), TestFixture]
    public class Test
    {
        [Test]
        public void IsPlusWorking() => Assert.AreEqual(10, Utils.Plus(5, 5));

        [Test]
        public void IsPlusWorkingWithNegativeNumbers() => Assert.AreEqual(-8, Utils.Plus(-5, -3));
    }
}
