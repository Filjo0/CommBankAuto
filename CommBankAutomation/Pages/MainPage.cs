using CommBankAutomation.Selenium;

namespace CommBankAutomation.Pages
{
    public class MainPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress);
        }
    }
}