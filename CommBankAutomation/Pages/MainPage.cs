﻿using System;
using CommBankAutomation.Selenium;
using Selenium.WebDriver.Extensions;

namespace CommBankAutomation.Pages
{
    public class MainPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress);
            
            Driver.Wait(TimeSpan.FromSeconds(5));
        }

        public static void SelectOverseasPayment()
        {
            var linkTransfer = Driver.Instance.FindElement(By.JQuerySelector("[data-tracker-type='button']:contains('Overseas payment')"));
            linkTransfer.Click();
            
            Driver.Wait(TimeSpan.FromSeconds(5));
        }
    }
}