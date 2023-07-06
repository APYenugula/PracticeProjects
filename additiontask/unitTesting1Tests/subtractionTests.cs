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
    public class subtractionTests
    {
        subtraction s = new subtraction();
        [TestMethod()]
        public void DifferenceTest()
        {
            int e=s.difference(12, 1);
            int expected = 11;
            Assert.AreEqual(expected, e);
            Assert.ThrowsException<Exception>(()=> s.difference(int.MinValue, 1));
            //Assert.ThrowsException<Exception>(() => e);
            //Assert.Fail();
        }
    }
}