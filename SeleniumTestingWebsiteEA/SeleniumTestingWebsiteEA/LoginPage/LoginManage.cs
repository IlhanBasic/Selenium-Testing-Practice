using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestingWebsiteEA.LoginPage
{
	public class LoginManage
	{
		private readonly IWebDriver driver;

		public LoginManage(IWebDriver driver)
        {
			this.driver = driver;
		}
		IWebElement loginLink => driver.FindElement(By.Id("loginLink"));
		IWebElement txtUserName => driver.FindElement(By.Id("UserName"));
		IWebElement txtPassword => driver.FindElement(By.Id("Password"));
		IWebElement submitLogin => driver.FindElement(By.Id("loginIn"));
		IWebElement profileButton => driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/form/ul/li[1]/a"));
		IWebElement manageUsersButton => driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/ul/li[5]/a"));

		public void GoToLoginPage()
		{
			loginLink.Click();
		}
		public void LoginUser(string username,string password)
		{
			txtUserName.SendKeys(username);
			txtPassword.SendKeys(password);
			submitLogin.Click();
			Assert.IsTrue(profileButton.Displayed);//login means this button exist
		}
		public (bool isLogged,bool isAdmin) CheckIsUserAdmin()
		{
			return (profileButton.Displayed,manageUsersButton.Displayed);
		}
    }
}
