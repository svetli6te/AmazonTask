using AmazonTests.Pages.Base;
using OpenQA.Selenium;

namespace AmazonTests.Pages.Basket
{
    public partial class BasketPage : BasePage
    {
        public BasketPage(IWebDriver driver) : base(driver)
        {
        }

        public bool CheckIfTheCorrectDesignIsDisplayed()
        {
            return DoesElementExist(ADDED_TO_BASKET_NOTIFICATION);
             
        }

        public void EditBasket()
        {
            ClickOn(EDIT_BASKET_BUTTON);
            WaitUntilPageIsLoaded();
        }
    }
}
