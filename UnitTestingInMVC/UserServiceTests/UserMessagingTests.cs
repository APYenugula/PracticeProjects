using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbConnector;
using Moq;

namespace UserService.Tests
{
    [TestClass()]
    public class UserMessagingTests
    {
        UserMessaging userMessagingService;
        [TestInitialize]
        public void Init()
        {
            //Mock<IDatabase> mockDabaseConnector = new Mock<IDatabase>();
            //mockDabaseConnector.Setup(m => m.WelcomeMsg(It.IsAny<string>())).Returns(Welcome_User_Test_SuccessFull);


            //userMessagingService = new UserMessaging(mockDabaseConnector.Object);

        }
        //[TestMethod()]
        //public void dbdataTest()
        //{
        //    var expected = "this is coming from database";
        //    //var output1=
        //    Database d = new Database();
        //    var res = d.Info();
        //    Assert.AreEqual(expected,res);
        //}
        [TestMethod()]
        //public void Welcome_User_Test_SuccessFull()
        //{
        //    string msg = userMessagingService.GetWelcomeUserMsg("2");

        //    Assert.IsTrue(msg.Count() > 0);
        //}
        public void Welcome_User_Test_SuccessFull_With_Existing_UserId_As_Paramenter()
        {
            Mock<IDatabase> mockDabaseConnector = new Mock<IDatabase>();
            mockDabaseConnector.Setup(m => m.WelcomeMsg("1")).Returns("A");
            userMessagingService = new UserMessaging(mockDabaseConnector.Object);
            string msg = userMessagingService.GetWelcomeUserMsg("1");

            Assert.AreEqual("A", msg);
            Assert.IsTrue(msg.Count() > 0);
        }
    }
}