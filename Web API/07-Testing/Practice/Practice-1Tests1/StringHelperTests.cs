using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Practice_1;

namespace ConsoleApp7.Tests
{
    [TestClass()]
    public class StringHelperTests
    {
        private Mock<IHttpService> HttpServiceMock = new Mock<IHttpService>();

        [TestMethod()]
        public void ContainsVowelTest()
        {
            string test = "Gigi";
            bool expected = true;
            var stringhelper = new StringHelper(HttpServiceMock.Object);

            var result = stringhelper.ContainsVowel(test);

            Assert.AreEqual(expected,result);
        }

        [TestMethod()]
        public void ReverseStringTest()
        {
            string test = "Gigi";
            string expected = "igiG";
            var stringhelper = new StringHelper(HttpServiceMock.Object);

            HttpServiceMock.Setup(x => x.SendResult())
                .Returns("Very Successful HttpResult");

            var result = stringhelper.ReverseString(test);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ContainsSubstringTest()
        {
            string test = "test";
            string substring = "est";
            bool expected = true;
            var stringhelper = new StringHelper(HttpServiceMock.Object);

            var result = stringhelper.ContainsSubstring(test,substring);

            Assert.AreEqual(expected, result);
        }
    }
}