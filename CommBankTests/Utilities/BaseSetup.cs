using CommBankAutomation.Selenium;
using NUnit.Framework;

namespace TestProject1.Utilities
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