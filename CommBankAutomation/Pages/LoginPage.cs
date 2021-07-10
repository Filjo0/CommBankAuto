using System.Linq;
using CommBankAutomation.Selenium;
using OpenQA.Selenium;

namespace CommBankAutomation.Pages
{
    public static class LoginPage
    {
        public static void GoTo()
        {
            var netBankButton = Driver.Instance.FindElement(By.CssSelector("[data-tracker-locationid='tl-nb-logon']"));
            netBankButton.Click();

            Driver.Instance.SwitchTo().Window(Driver.Instance.WindowHandles.First()).Close();
            Driver.Instance.SwitchTo().Window(Driver.Instance.WindowHandles.Last());

            var forms = Driver.Instance.FindElements(By.CssSelector("span.quickTitle"));

            foreach (var form in forms)
            {
                if (!form.Text.Equals("Online")) continue;
                form.Click();
            }
        }

        public static bool IsAt
        {
            get
            {
                var loginInput = Driver.Instance.FindElement(By.Id("txtMyClientNumber_field")).Displayed;
                var passwordInput = Driver.Instance.FindElement(By.Id("txtMyPassword_field")).Displayed;
                var logOnButton = Driver.Instance.FindElement(By.Id("btnLogon_field")).Displayed;
                return loginInput && passwordInput && logOnButton;
            }
        }
    }
}