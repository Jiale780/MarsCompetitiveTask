using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace MarsCompetitiveTask.Pages
{
    class HomePage
    {
        private IWebDriver testDriver;

        private IWebElement MouseHover => testDriver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[2]/div/span"));

        private IWebElement GoToProfile => testDriver.FindElement(By.XPath("//*[@id='service-search-section']/div[1]/div[2]/div/span/div/a[1]"));
  
        private IWebElement ShareSkills => testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/div[2]/a"));

        private IWebElement ManageListing => testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[3]"));

        public void NaviHomePage(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            Actions Hover = new Actions(testDriver);
            // Select the Seller from "Seller" dropdown list
            Hover.MoveToElement(MouseHover).Perform();
            // Select the "Go to Profile" from "Seller" dropdown list
            GoToProfile.Click();
        }

        public void ShareSkillBtn(IWebDriver testDriver)
        {
            // Navigate to the Share Skill Button
            this.testDriver = testDriver;
            ShareSkills.Click();
        }

        public void NaviManageListings(IWebDriver testDriver)
        {
            // Navigate to the Manage Listings Tab
            this.testDriver = testDriver;
            ManageListing.Click();
        }
    }
}
