using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsPipelineTest.Tests
{
    [TestClass]
    public class PipelineServiceTest
    {
        private PipelineService _service;

        [TestInitialize]
        public void SetUp()
        {
            _service = new PipelineService();
        }

        [TestMethod]
        public void CanSayHello()
        {
            var greeting = _service.GetGreeting();

            Assert.AreEqual("Hello", greeting);
        }

        [TestMethod]
        public void CanAdd_ShouldFailThisTest()
        {
            Assert.AreEqual(10, _service.AddNumbers(5,5));
        }
    }
}
