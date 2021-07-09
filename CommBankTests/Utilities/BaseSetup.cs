using CommBankAutomation.Selenium;
using NUnit.Framework;

namespace CommBankTests.Utilities
{
    [TestFixture]
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