using Microsoft.VisualStudio.TestTools.UnitTesting;
using unitTesting1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTesting1.Tests
{
    [TestClass()]
    public class multiplicationTests
    {
        multiplication m=new multiplication();
        [TestMethod()]
        public void mulTest()
        {
            int y=m.mul(2, 3);
            int f = 6;
            Assert.AreEqual(f, y);
            Assert.ThrowsException<Exception>(() => m.mul(int.MaxValue, 3));
            //Assert.Fail();
        }
    }
}