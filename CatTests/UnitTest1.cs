using Cats;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices;

namespace CatTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void InteritsBaseInFirstConstructor()
        {
            HouseCat keyboardCat = new HouseCat("Keyboard Cat", 7);
            Assert.AreEqual(7, keyboardCat.Weight, .001);
        }

        [TestMethod]
        public void InheritsDefaultCatInSecondConstructor()
        {
            HouseCat keyboardCat = new HouseCat("Keyboard Cat");
            Assert.AreEqual(13, keyboardCat.Weight);
        }
    }
}
