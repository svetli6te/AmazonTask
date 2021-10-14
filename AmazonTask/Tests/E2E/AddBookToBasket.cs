using AmazonTests.Pages.Basket;
using AmazonTests.Pages.Home;
using AmazonTests.Pages.Product;
using AmazonTests.Pages.SearchResult;
using NUnit.Framework;

namespace AmazonTests.Tests.E2E
{
    [TestFixture]
    public class AddBookToBasket : BaseTest
    {
        private HomePage _homePage;
        private SearchResultPage _searchResultPage;
        private ProductPage _productPage;
        private BasketPage _basketPage;

        [SetUp]
        public void OpenBrowserWindowAndNavigateToHomePage()
        {
            InitializeBrowser();
            _homePage = new HomePage(Driver);
            _searchResultPage = new SearchResultPage(Driver);
            _productPage = new ProductPage(Driver);
            _basketPage = new BasketPage(Driver);

            _homePage.Open();
            _homePage.AssertHomePageisLoaded();
            _homePage.AcceptCookies();
        }

        [TestCase("Harry Potter and the Cursed Child",
                  "Harry Potter and the Cursed Child - Parts One and Two: The Official Playscript of the Original West End Production",
                  "Paperback")]    
        public void BasketIsUpdatedCorrectly_When_aBookIsAdded(string bookTitleSearch, string expectedBookTitle, string expectedBookVersion)
        {
            string expectedBookPrice;
            bool isCorrectDesign = false;
            
            _homePage.SearchForBook(bookTitleSearch);

            _searchResultPage.VerifyFirstResultTitle(expectedBookTitle);
            expectedBookPrice = _searchResultPage.VerifyFirstResultHasPaperbackVersion(expectedBookVersion).Trim();

            _searchResultPage.OpenFirstResultProduct();
            _productPage.SelectPaperbackVersion();

            _productPage.VerifyPaperbackVersionIsSelected(expectedBookTitle, expectedBookVersion, expectedBookPrice);

            _productPage.AddProductToBasket();

            isCorrectDesign = _basketPage.CheckIfTheCorrectDesignIsDisplayed();

            if (isCorrectDesign == true)
            {
                _basketPage.VerifyNotificationIsShown();
                _basketPage.VerifyProductIsAddedToBasketCorrectly("Basket subtotal (1 item): ", expectedBookPrice);
                _basketPage.EditBasket();
            }
            else
            {
                _basketPage.VerifyNotificationV2IsShown();
                _homePage.ClickBasketButton();
            }

            _basketPage.VerifySubTotalInformation(expectedBookTitle, expectedBookVersion, expectedBookPrice);
        }

        [TearDown]
        public void CloseBrowserWindow()
        {
            CloseBrowser();
        }
    }
}
