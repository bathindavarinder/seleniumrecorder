namespace TestNamespace
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    /// <summary>
    /// POM of GooglePOM
    /// </summary>
    public class GooglePOM
    {

        #region Constructor

        private IWebDriver driver;

        private string title;

        public GooglePOM(IWebDriver driver)
        {

            this.driver = driver;

            this.title = driver.Title;
        }
        #endregion

        #region Properties

        public IWebElement lst_ib
        {
            get
            {
                return driver.FindElement(By.Id("lst-ib"));
            }
        }

        public IWebElement btnK
        {
            get
            {
                return driver.FindElement(By.Name("btnK"));
            }
        }

        public IWebElement btnI
        {
            get
            {
                return driver.FindElement(By.Name("btnI"));
            }
        }


        #endregion
    }
}
