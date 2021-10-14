using AmazonTests.Pages.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonTests.Pages.SearchResult
{
    public partial class SearchResultPage : BasePage
    {
        private static string commonWidgetLocator = "//*[contains(@cel_widget_id,'MAIN-SEARCH_RESULTS')]";

        public static readonly By FIRST_RESULT_TITLE = By.XPath
                    ($"{commonWidgetLocator}//h2//span");

        public static readonly By FIRST_RESULT_VERSION_PAPERBACK = By.XPath
                    ($"{commonWidgetLocator}//a [@class='a-size-base a-link-normal a-text-bold'][normalize-space(text())='Paperback']");

        public static readonly By FIRST_RESULT_PAPERBACK_PRICE = By.XPath
                        ($"{commonWidgetLocator}//a [@class='a-size-base a-link-normal a-text-bold'][normalize-space(text())='Paperback']//following::span[@class='a-price'][1]");

        public static readonly By PRICE_SYMBOL = By.XPath
                    ($"{commonWidgetLocator}//a [@class='a-size-base a-link-normal a-text-bold'][normalize-space(text())='Paperback']//following::span[@class='a-price-symbol'][1]");
        public static readonly By PRICE_WHOLE = By.XPath
                    ($"{commonWidgetLocator}//a [@class='a-size-base a-link-normal a-text-bold'][normalize-space(text())='Paperback']//following::span[@class='a-price-whole'][1]");
        public static readonly By PRICE_FRACTION = By.XPath
                    ($"{commonWidgetLocator}//a [@class='a-size-base a-link-normal a-text-bold'][normalize-space(text())='Paperback']//following::span[@class='a-price-fraction'][1]");
    }
}
