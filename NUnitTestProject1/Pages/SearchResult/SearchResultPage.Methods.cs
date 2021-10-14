using AmazonTests.Pages.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonTests.Pages.SearchResult
{
    public partial class SearchResultPage : BasePage
    {
        public SearchResultPage(IWebDriver driver) : base(driver)
        {
        }

        public void OpenFirstResultProduct()
        {
            ClickOn(FIRST_RESULT_TITLE);
        }
    }
}
