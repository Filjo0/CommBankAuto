using CommBankAutomation.Selenium;
using Selenium.WebDriver.Extensions;

namespace CommBankAutomation.Pages
{
    public static class MoneyTransferPage
    {
        public static bool IsAt
        {
            get
            {
                var moneyTransferHeader = Driver.Instance.FindElement(By.JQuerySelector("h2:contains('International Money Transfer (IMT)')"));
                var sendNowButton = Driver.Instance.FindElement(By.JQuerySelector("a:contains('Send now')"));

                return moneyTransferHeader.Displayed && sendNowButton.Displayed;
            }
        }

        public static void GoTo()
        {
            MainPage.GoTo();
            MainPage.SelectOverseasPayment();
        }

        public static void LogOnToNetBank()
        {
            var logOnToNetBankLink = Driver.Instance.FindElement(By.JQuerySelector("[data-tracker-locationid='tl-nb-logon']:contains('NetBank')"));
            logOnToNetBankLink.Click();
        }
    }
}