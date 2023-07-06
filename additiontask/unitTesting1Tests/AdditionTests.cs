using Microsoft.VisualStudio.TestTools.UnitTesting;
using unitTesting1.addition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTesting1.addition.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        Addition a = new Addition();
        

        [TestMethod()]
        public void addTest()
        {
            int c = a.add(12, 13);
            int expected = 25;
            Assert.AreEqual(c,expected);
            Assert.ThrowsException<Exception>(()=>a.add(int.MaxValue, 13));
            //Assert.Fail();
        }
    }
}