using AventStack.ExtentReports;
using MarsCompetitiveTask.Pages;
using MarsCompetitiveTask.Utils;
using NUnit.Framework;

namespace MarsCompetitiveTask.NUnitTests
{
    [TestFixture]
    class ManageListTest : CommonDriver
    {
        [Test, Order(1)]
        public void ViewManageListingsTest()
        {
            test = extent.CreateTest("Deleted Share Skill and Manage listing is Deleted");
            test.Log(Status.Info, "Browser Initialisation");
            // Login Page object initialization and definition
            LoginPage loginPageObj = new LoginPage(testDriver);

            loginPageObj.LoginSteps(testDriver);

            // Manage Listings Page object initialization and definition
            ManageListings manageListsObj = new ManageListings(testDriver);
            manageListsObj.NavigateManageListings();
            manageListsObj.ViewManageListingsActive(testDriver);
            test.Log(Status.Info, "Manage Listings of Share Skill is Deleted");
        }

        [Test, Order(2)]
        public void DeleteManageListingsTest()
        {
            test = extent.CreateTest("Deleted Share Skill and Manage listing is Deleted");
            test.Log(Status.Info, "Browser Initialisation");
            // Login Page object initialization and definition
            LoginPage loginPageObj = new LoginPage(testDriver);

            loginPageObj.LoginSteps(testDriver);

            // Manage Listings Page object initialization and definition
            ManageListings manageListsObj = new ManageListings(testDriver);
            manageListsObj.NavigateManageListings();
            manageListsObj.DeleteManageListingBtn();
            test.Log(Status.Info, "Manage Listings of Share Skill is Deleted");
        }
    }
}
