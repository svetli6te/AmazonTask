﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AmazonTests.Pages.Base
{
    public partial class BasePage
    {
        public static readonly double _maxWaitTime = 10000d;
        public static readonly double _pollInterval = 500d;

        public void WaitUntilElementIsDisplayed(By elementLocator)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(_maxWaitTime));
            wait.PollingInterval = TimeSpan.FromMilliseconds(_pollInterval);
            wait.Message = "Element not found";

            wait.Until(condition =>
            {
                try
                {
                    var isDisplayed = Driver.FindElement(elementLocator).Displayed;

                    if (isDisplayed == false)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception e)
                {
                    Type exType = e.GetType();

                    if (exType == typeof(StaleElementReferenceException) ||
                        exType == typeof(NoSuchElementException))
                    {
                        return false;
                    }
                    else
                    {
                        throw;
                    }
                }
            });
        }

        public bool DoesElementExist(By elementLocator)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(_maxWaitTime));
            wait.PollingInterval = TimeSpan.FromMilliseconds(_pollInterval);
            wait.Message = "Element not found"; 
            try
            {
                var isDisplayed = Driver.FindElement(elementLocator).Displayed;
                if (isDisplayed == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Type exType = e.GetType();
                if (exType == typeof(StaleElementReferenceException) ||
                    exType == typeof(NoSuchElementException))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }            
        }

        public void WaitUntilPageIsLoaded()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(_maxWaitTime));

            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
    }
}
