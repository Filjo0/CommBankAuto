using CommBankAutomation.Selenium;
using Selenium.WebDriver.Extensions;

namespace CommBankAutomation.Pages
{
    public class OrderTravelCardPage
    {
        public static void SelectOnline()
        {
            var selectOnline = Driver.Instance.FindElement(By.JQuerySelector(".quickOption:contains('Online')"));
            selectOnline.Click();
        }
    }
}