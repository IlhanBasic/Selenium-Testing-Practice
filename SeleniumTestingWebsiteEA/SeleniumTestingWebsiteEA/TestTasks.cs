using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestingWebsiteEA
{
	public class TestTasks
	{
		IWebDriver driver;
		[SetUp]
		public void Setup()
		{
			driver = new ChromeDriver();
			driver.Navigate().GoToUrl("http://eaapp.somee.com/");
		}
		[Test]
		public void LoginUser()
		{

		}
		[Test]
		public void IsUserAdmin()
		{

		}
		[Test]
		public void AddEmployee()
		{

		}
		[Test]
		public void RemoveEmployee()
		{

		}
		[Test]
		public void EditEmployee()
		{

		}
		[Test]
		public void SearchEmployee()
		{

		}
		[Test]
		public void ChangeRoleToUser()
		{

		}
		[TearDown]
		public void TearDown()
		{
			driver.Close();
		}
	}
}
