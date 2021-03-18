using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zad1;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        Plecak TestBackpack = new Plecak(10, 50, 50);

        [TestMethod]
        public void TestMethod1()
        {
            using (var x = new StringWriter())
            {
                var test = new StringWriter();
                Console.SetOut(test);
                TestBackpack.GenerateItems();
                TestBackpack.WriteList();
                var y = test.ToString().Trim();
                Console.SetOut(x);
                Program.Main();
                var res = x.ToString().Trim();
                Assert.AreEqual(res, y);
                
            }
        
        }
    }
}
