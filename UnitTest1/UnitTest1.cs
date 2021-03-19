using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zad1;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        Plecak TestBackpack = new Plecak(10,50,50);

        [TestMethod]
        public void TestMain()
        {
            Assert.IsNotNull(TestBackpack);
            var x = new StringWriter();
            TestBackpack.GenerateItems();
            Console.SetOut(x);
            TestBackpack.GatherItems();
            var res1 = x.ToString().Trim();
            var y = new StringWriter();
            Console.SetOut(y);
            Zad1.Program.Main();
            var res2 = y.ToString().Trim();
            Assert.AreEqual(res1, res2);
        }

        [TestMethod]
        public void TestSorting()
        {
            Plecak Backpack1 = new Plecak(15, 60, 60);
            Plecak Backpack2 = new Plecak(15, 60, 60);
            Assert.IsNotNull(Backpack1);
            Assert.IsNotNull(Backpack2);
            var res1 = Backpack1.WriteAllItems();
            var res2 = Backpack2.WriteAllItems();
            Assert.AreEqual(res1, res2);
        }

        [TestMethod]
        public void TestGatherItems()
        {
            Plecak Backpack1 = new Plecak(15, 60, 60);
            Plecak Backpack2 = new Plecak(2, 60, 60);
            var res1 = Backpack1.WriteListBackpack();
            var res2 = Backpack2.WriteListBackpack();
            Assert.AreEqual(res1, res2);
        }

        [TestMethod]
        public void TestGenereting()
        {
            Plecak Backpack1 = new Plecak(15, 60, 60);
            Plecak Backpack2 = new Plecak(40, 60, 60);
            var res1 = Backpack1.WriteAllItems();
            var res2 = Backpack2.WriteAllItems();
            Assert.IsFalse(res1 == res2); 
        }

        [TestMethod]
        public void TestWeight()
        {
            Plecak Backpack2 = new Plecak(50, 60, 60);
            var res = Backpack2.WriteAllItems();
            Backpack2.GatherItems();
            if (Backpack2.weightMax < Backpack2.WeightCurrent)
            {
                Assert.Fail();
            }
            else
            {
                Assert.IsTrue(Backpack2.weightMax > Backpack2.WeightCurrent);
            }
        }

    }
}
