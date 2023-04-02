using CommBankAutomation.Selenium;
using NUnit.Framework;

namespace CommBankTests.Utilities
{
    public class BaseSetup
    {
        [SetUp]
        public void Init()
        {
            Driver.Initialize();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.Close();
        }
    }
}