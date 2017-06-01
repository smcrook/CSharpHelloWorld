using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }

        [Test]
        public void FailMethod()
        {
            Assert.Fail("We Expect to fail");
        }
    }
}
