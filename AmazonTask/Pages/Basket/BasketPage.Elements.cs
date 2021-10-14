﻿using AmazonTests.Pages.Base;
using OpenQA.Selenium;

namespace AmazonTests.Pages.Basket
{
    public partial class BasketPage : BasePage
    {
        public static readonly By ADDED_TO_BASKET_SUBTOTAL = By.XPath
                                ("//div[@id='hlb-subcart']//span[@class='a-size-medium a-align-center huc-subtotal']");

        public static readonly By FIRST_PRODUCT_TITLE = By.XPath
                                ("//span[@class='a-size-medium a-color-base sc-product-title'] | //span[@class='a-truncate a-size-base-plus']");

        public static readonly By FIRST_PRODUCT_VERSION = By.XPath
                                ("//span[@class='a-list-item']//span[@class='a-size-small sc-product-binding a-text-bold']");

        public static readonly By ADDED_TO_BASKET_NOTIFICATION = By.XPath("//div[@id='huc-v2-order-row-items-msg']//h1");

        public static readonly By ADDED_TO_BASKET_NOTIFICATION_V2 = By.XPath("//div[@id='sw-atc-confirmation']//span");

        public static readonly By EDIT_BASKET_BUTTON = By.XPath("//a[@id='hlb-view-cart-announce']");       

        public static readonly By SUBTOTAL_TEXT = By.XPath("//span[@id='sc-subtotal-label-activecart']");

        public static readonly By SUBTOTAL_AMOUNT = By.XPath("//span[@id='sc-subtotal-amount-activecart']");
    }
}
