using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cloud_HW_Yanova.Models;

namespace Cloud_HW_Yanova.Test
{
    [TestClass]
    public class UnitTesting
    {
        [TestMethod]
        public void HelloTest()
        {
            string testName = "Алена";

            string res = VotingController.Hello(testName);

            Assert.AreEqual("Привет, Алена!", res);
        }
    }
}
