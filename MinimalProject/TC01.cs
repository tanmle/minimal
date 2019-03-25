using System;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace MinimalProject
{
    [TestFixture]
    public class TC01
    {
        private ChromeDriver driver;

        [Test]
        public void MyExample()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(new Uri("http://google.com"));
            var assertion = true;
            assertion.Should().BeTrue("Oke");
            assertion.Should().BeFalse("Ko Oke");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
