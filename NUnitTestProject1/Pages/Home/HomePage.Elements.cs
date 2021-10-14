﻿using AmazonTests.Pages.Base;
using OpenQA.Selenium;

namespace AmazonTests.Pages.Home
{
    public partial class HomePage : BasePage
    {
        public const string HOME_PAGE_URL = "https://www.amazon.co.uk/";

        //-------------------------locators----------------------------------------------------------------
        public static readonly By ACCEPT_COOKIES_BUTTON = By.Id("sp-cc-accept");
        public static readonly By SEARCH_CATEGORY_DROPDOWN = By.Id("searchDropdownBox");
        public static readonly By SEARCH_FIELD = By.Id("twotabsearchtextbox");
        public static readonly By SEARCH_GO_BUTTON = By.XPath("//input[@id='nav-search-submit-button']");
        public static readonly By GO_TO_BASKET_BUTTON = By.XPath("//div[@id='nav-cart-text-container']");
    }
}
