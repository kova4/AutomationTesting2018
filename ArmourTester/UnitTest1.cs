using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Testing2018;

namespace ArmourTester
{
    [TestClass]
    public class UnitTest1
    {
        Armour ar = new Armour("Kypärä", "Hieno kypärä", 20, 0, 1);

        [TestMethod]
        public void TestName()
        {
            string name = ar.getName();
 
            //name ei voi olla tyhjä
            if (name == null || name == "")
            {
                Assert.Fail("name ei voi olla tyhjä");
            }
        }

        [TestMethod]
        public void TestDesc()
        {
            string desc = ar.getDesc();

            //desc ei voi olla tyhjä
            if (desc == null || desc == "")
            {
                Assert.Fail("desc ei voi olla tyhjä");
            }
        }

        [TestMethod]
        public void TestProt()
        {
            int prot = ar.getCurProt();

            //prot ei voi olla pienempi kuin 0 (ellei ole tarkoitus olla armoria joka antaa miinusta, tuskin on)
            if (prot < 0)
            {
                Assert.Fail("prot ei voi olla pienempi kuin 0");
            }
        }

        [TestMethod]
        public void TestMaxProt()
        {
            int maxprot = ar.getMaxProt();
            int prot = ar.getCurProt();

            //prot ei voi olla isompi kuin maxprot
            if (prot > maxprot)
            {
                Assert.Fail("prot ei voi olla isompi kuin maxprot");
            }
        }

        [TestMethod]
        public void TestSlot()
        {
            int slot = ar.getSlot();

            //slot ei voi olla pienempi kuin 0 tai isompi kuin 3
            if (slot < 0 || slot > 3)
            {
                Assert.Fail("slot ei voi olla pienempi kuin 0 tai isompi kuin 3");
            }

            if (slot != 0)
            {
                Assert.Fail("Hatun on oltava slotissa 0");
            }
        }

        [TestMethod]
        public void TestLevel()
        {
            int lvl = ar.getLevel();

            //lvl ei voi olla 0 tai pienempi kuin 0
            if (lvl <= 0)
            {
                Assert.Fail("lvl ei voij olla 0 tai pienempi kuin 0");
            }
        }
     }
}
