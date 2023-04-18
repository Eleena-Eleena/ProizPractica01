using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Taro.Pages;
using Taro.Resources;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Search()
        {
            int glossary1 = 5;
            Assert.AreEqual(5, glossary1);  
        }
    }
}
