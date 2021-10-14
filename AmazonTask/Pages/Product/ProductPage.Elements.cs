using AmazonTests.Pages.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonTests.Pages.Product
{
    public partial class ProductPage : BasePage
    {
        public static readonly By BOOK_VERSION_PAPERBACK = By.XPath
            ("//*[@class='a-unordered-list a-nostyle a-button-list a-horizontal']//span [@class='a-button-inner']//span[normalize-space(text())='Paperback']");

        public static readonly By BOOK_TITLE = By.XPath("//*[@id='title']//span [@id='productTitle']");
        public static readonly By BOOK_SUBTITLE = By.XPath("//*[@id='title']//span [@id='productSubtitle']");
        public static readonly By BOOK_PRICE = By.XPath
            ("//*[@id='tmmSwatches']//span [@class='a-size-base a-color-price a-color-price']");

        public static readonly By ADD_TO_CART_BUTTON = By.XPath("//input [@id='add-to-cart-button']");

    }
}

