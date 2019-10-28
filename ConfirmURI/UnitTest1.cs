using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Searchie
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_GoodURL()
        {
            Searchie searchie = new Searchie(new httpService());
            bool urlBool = searchie.CheckUrl("http://google.com.au");
            Assert.AreEqual(urlBool, true);
        }
        [TestMethod]
        public void Test_BadURL()
        {
            Searchie searchie = new Searchie(new httpService());
            bool urlBool = searchie.CheckUrl("http://google.com<>.au");
            Assert.AreEqual(urlBool, false);
        }
    }
}
