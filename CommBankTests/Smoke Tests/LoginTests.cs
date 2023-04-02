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
            Assert.IsTrue(MoneyTransferPage.IsAt, "Failed to open MoneyTransfer page.");
        }

        [Test]
        public void Can_Go_To_Login_Page()
        {
            MoneyTransferPage.GoTo();
            LoginPage.GoTo();
            Assert.IsTrue(LoginPage.IsAt, "Failed to open Login page.");
        }
    }
}