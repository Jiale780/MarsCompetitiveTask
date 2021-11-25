using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using MarsCompetitiveTask.Pages;
using MarsCompetitiveTask.Utils;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace MarsCompetitiveTask.NUnitTests
{
    [TestFixture]
    class LoginTest : CommonDriver
    {
        [Test]
        public void LoginPageTest()
        {
            test = extent.CreateTest("Login");
            test.Log(Status.Info, "User Login");

            // Login Page object initialization and definition
            LoginPage loginPageObj = new LoginPage(testDriver);
            loginPageObj.LoginSteps(testDriver);
            TestContext.WriteLine(loginPageObj);
        }
    }
}
