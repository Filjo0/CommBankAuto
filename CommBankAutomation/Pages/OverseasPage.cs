using System.Linq;
using CommBankAutomation.Selenium;
using OpenQA.Selenium;

namespace CommBankAutomation.Pages
{
    public static class OverseasPage
    {
        public static bool IsAt
        {
            get
            {
                var overseasPageElementsH3 = Driver.Instance.FindElements(By.CssSelector("h3"));
                var overseasPageElementsH2 = Driver.Instance.FindElements(By.CssSelector("h2"));

                var feesAndChargesElementExists =
                    overseasPageElementsH3.Any(element => element.Text.Equals("Fees and charges"));

                var receivingMoneyFromOverseasElementExists =
                    overseasPageElementsH2.Any(element => element.Text.Equals("Receiving money from overseas"));

                return feesAndChargesElementExists && receivingMoneyFromOverseasElementExists;
            }
        }

        public static void GoTo()
        {
            MainPage.GoTo();

            var linkTransfer = Driver.Instance.FindElement(By.LinkText("Overseas payment"));
            linkTransfer.Click();
        }
    }
}