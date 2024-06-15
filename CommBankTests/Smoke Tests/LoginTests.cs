using CommBankAutomation.Pages;
using CommBankTests.Utilities;
using NUnit.Framework;

namespace CommBankTests.Smoke_Tests
{
    public class LoginTests : BaseSetup
    {
        [Test]
        public void Can_Go_To_Money_Transfer_Page()
        {
            MoneyTransferPage.GoTo();
            Assert.That(MoneyTransferPage.IsAt, Is.True, "Failed to open MoneyTransfer page.");
        }

        [Test]
        public void Can_Go_To_Login_Page()
        {
            MoneyTransferPage.GoTo();
            LoginPage.GoTo();
            Assert.That(LoginPage.IsAt, Is.True, "Failed to open Login page.");
        }
    }
}