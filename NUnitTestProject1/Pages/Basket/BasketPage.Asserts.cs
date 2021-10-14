using AmazonTests.Pages.Base;
using NUnit.Framework;

namespace AmazonTests.Pages.Basket
{
    public partial class BasketPage : BasePage
    {

        public void VerifyNotificationIsShown()
        {
            string notification = Driver.FindElement(ADDED_TO_BASKET_NOTIFICATION).Text.Trim();

            Assert.That(notification, Is.EqualTo("Added to Basket"));
        }

        public void VerifyNotificationV2IsShown()
        {
            string notification = Driver.FindElement(ADDED_TO_BASKET_NOTIFICATION_V2).Text.Trim();

            Assert.That(notification, Is.EqualTo("Added to Basket"));
        }

        public void VerifyProductIsAddedToBasketCorrectly(string expectedTitle, string expectedPrice)
        {
            string actualSubTotal = Driver.FindElement(ADDED_TO_BASKET_SUBTOTAL).Text;            
            
            Assert.That(actualSubTotal, Is.EqualTo(expectedTitle + expectedPrice));          
        }

        public void VerifySubTotalInformation(string expectedBookTitle, string expectedBookVersion,string expectedTotalPrice)
        {
            string expectedSubTotalText = "Subtotal (1 item):";
            string actualSubTotalText = Driver.FindElement(SUBTOTAL_TEXT).Text;
            string actualBookTitle = Driver.FindElement(FIRST_PRODUCT_TITLE).Text;
            string actualBookVersion = Driver.FindElement(FIRST_PRODUCT_VERSION).Text;
            string actualTotalPrice = Driver.FindElement(SUBTOTAL_AMOUNT).Text;

            Assert.Multiple(() =>
            {
                Assert.That(actualSubTotalText, Is.EqualTo(expectedSubTotalText) );
                Assert.That(actualBookTitle, Is.EqualTo(expectedBookTitle) );
                Assert.That(actualBookVersion, Is.EqualTo(expectedBookVersion) );
                Assert.That(actualTotalPrice.Trim(), Is.EqualTo(expectedTotalPrice));
            });
        }
    }
}
