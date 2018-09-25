using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApplication1
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void IsPlusWorking()
        {
            Assert.AreEqual(10, Program.Plus(5, 5));
        }
    }
}
