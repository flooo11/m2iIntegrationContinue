using System;
using IntegrationContinue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestIntegrationContinue
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Test_GetInt()
        {
            Assert.AreEqual(Calcul.GetInt("3"), 3);
        }
    }
}
