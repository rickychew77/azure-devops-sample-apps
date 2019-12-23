using asp_dotnetcore.Controllers;
using NUnit.Framework;
using Microsoft.AspNetCore.Mvc;

namespace asp_dotnetcore_nunit
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestPrivacy()
        {
            HomeController home = new HomeController();

            var result = home.Privacy() as ViewResult;

            Assert.That(result.ViewName, Is.EqualTo("Privacy"));
        }

        [Test]
        public void TestIndex()
        {
            HomeController home = new HomeController();

            var result = home.Index() as ViewResult;

            Assert.That(result.ViewName, Is.EqualTo("Index"));
        }
        [Test]
        public void TestAbout()
        {
            HomeController home = new HomeController();

            var result = home.About() as ViewResult;

            Assert.That(result.ViewName, Is.EqualTo("About"));
        }
    }
}