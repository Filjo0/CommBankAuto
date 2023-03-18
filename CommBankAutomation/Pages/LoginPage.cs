using System.Linq;
using CommBankAutomation.Selenium;
using Selenium.WebDriver.Extensions;

namespace CommBankAutomation.Pages
{
    public static class LoginPage
    {
        public static bool IsAt
        {
            get
            {
                var loginInput = Driver.Instance.FindElement(By.Id("txtMyClientNumber_field"));
                var passwordInput = Driver.Instance.FindElement(By.Id("txtMyPassword_field"));
                var logOnButton = Driver.Instance.FindElement(By.Id("btnLogon_field"));
                
                return loginInput.Enabled && passwordInput.Enabled && logOnButton.Enabled;
            }
        }

        public static void GoTo()
        {
            MoneyTransferPage.LogOnToNetBank();
            SwitchToNewWindow();
            OrderTravelCardPage.SelectOnline();
        }

        private static void SwitchToNewWindow()
        {
            Driver.Instance.SwitchTo().Window(Driver.Instance.WindowHandles.First()).Close();
            Driver.Instance.SwitchTo().Window(Driver.Instance.WindowHandles.Last());
        }
    }
}