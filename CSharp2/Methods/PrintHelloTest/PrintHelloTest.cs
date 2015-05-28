using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintHelloTest;

namespace PrintHelloTest
{
    [TestClass]
    public class PrintHelloTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           string name = PrintHello.PrintName("my name");
           Assert.AreEqual("my name", name);
        }
    }
}
