// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class Testw3schoolsTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void testw3schools() {
    driver.Navigate().GoToUrl("https://www.udemy.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(1280, 680);
    {
      var element = driver.FindElement(By.CssSelector(".carousel-billboard--carousel-item--cP_Bu:nth-child(2) img"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.TagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.LinkText("Log in")).Click();
    driver.FindElement(By.Id("id_password")).Click();
    driver.FindElement(By.Id("id_password")).SendKeys("nikitig1987@abv.bg");
    driver.FindElement(By.Id("submit-id-submit")).Click();
    {
      var element = driver.FindElement(By.Id("id_password"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).ClickAndHold().Perform();
    }
    {
      var element = driver.FindElement(By.CssSelector(".submit-row > span"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Release().Perform();
    }
    driver.FindElement(By.Id("login-form")).Click();
    {
      var element = driver.FindElement(By.Id("submit-id-submit"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.TagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.Id("id_password")).SendKeys("Pomorie@1234");
    driver.FindElement(By.Id("submit-id-submit")).Click();
    {
      var element = driver.FindElement(By.LinkText("Health & Fitness"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.Id("u106-popper-trigger--16"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.TagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    {
      var element = driver.FindElement(By.Id("u106-popper-trigger--18"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.TagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    {
      var element = driver.FindElement(By.Id("u106-popper-trigger--20"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.TagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    {
      var element = driver.FindElement(By.Id("u106-popper-trigger--22"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.TagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.CssSelector(".user-profile-dropdown--dropdown-button-avatar--kTGSm")).Click();
    {
      var element = driver.FindElement(By.Id("u252-popper-trigger--15"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.TagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    {
      var element = driver.FindElement(By.Id("u252-popper-trigger--17"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.TagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    {
      var element = driver.FindElement(By.CssSelector(".user-profile-dropdown--email--8WRg8"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.TagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    {
      var element = driver.FindElement(By.CssSelector(".ud-unstyled-list:nth-child(2) > li:nth-child(2) .ud-block-list-item-content"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.TagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.CssSelector(".ud-unstyled-list:nth-child(7) > li:nth-child(2) .ud-block-list-item-content")).Click();
    {
      var element = driver.FindElement(By.CssSelector("#u259-popper-trigger--20 > .ud-text-sm"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.Id("u259-popper-trigger--22"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.TagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
  }
}