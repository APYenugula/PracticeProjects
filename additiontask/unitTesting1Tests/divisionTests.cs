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
    public class divisionTests
    {
        division d=new division();
        [TestMethod()]
        public void diviTest()
        {
            int g=d.divi(10 , 5);
            int e = 2;
            Assert.AreEqual(e, g);
            //Assert.Fail();
            Assert.ThrowsException<Exception>(()=> d.divi(5 , 0));
        }
    }
}