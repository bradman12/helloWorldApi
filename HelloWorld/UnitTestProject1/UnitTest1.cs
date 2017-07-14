
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var greeting = "Hello World";
            var controller = new HelloWorldController();

            Assert.AreEqual(controller.Get(), greeting);
        }
    }

    public class HelloWorldController 
    {
        public string Get()
        {
            var greeting = "Hello World";
            return greeting;
        }
    }

}
