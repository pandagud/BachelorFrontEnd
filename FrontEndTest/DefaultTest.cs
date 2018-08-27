using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FrontEndTest
{
    //Capperdapper laver git-test
    [TestFixture]
    public class DefaultTest
    {
        [Test]
        public void BasicDefaultTest()
        {
            Assert.AreEqual(4, 4);
        }
    }
}
