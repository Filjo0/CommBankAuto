using CommBankAutomation.Pages;
using CommBankTests.Utilities;
using NUnit.Framework;

namespace CommBankTests.Smoke_Tests
{
    [TestFixture]
    public class Tests : BaseSetup
    {
        [Test]
        public void User_Can_Go_To_Overseas_Page()
        {
            OverseasPage.GoTo();
            Assert.IsTrue(OverseasPage.IsAt, "Failed to open OverseasPage");
        }

        [Test]
        public void User_Can_Go_To_Login_Page()
        {
            OverseasPage.GoTo();
            LoginPage.GoTo();
            Assert.IsTrue(LoginPage.IsAt, "Failed to open Login page");
        }
    }
}