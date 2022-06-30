using BigSmall.Utilites;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigSmall.CommonMethodObject
{
  public  class BigSmallObject
    {
        public void Homepage()
        {
            BaseClass.Driver.Manage().Window.Maximize();
        }

        public  void Click()
        {
            IWebElement home = BaseClass.Driver.FindElement(By.XPath("//*[@id='myheader']/div[1]/div/div/ul/li[4]/a"));
            home.Click();
        }
        public void Name()
        {
            IWebElement Name = BaseClass.Driver.FindElement(By.Id("contactFormName"));
            Name.SendKeys("Prasad");
        }
        public void Email()
        {
            IWebElement Email = BaseClass.Driver.FindElement(By.XPath("//*[@id='contactFormEmail']"));
            Email.SendKeys("Anup@gmail.com");
        }
        public void Phone()
        {
            IWebElement Phone = BaseClass.Driver.FindElement(By.XPath("//*[@id='contactFormPhone']"));
            Phone.SendKeys("987654321");
        }
        public void Enquiry()
        {
            IWebElement Enquiry = BaseClass.Driver.FindElement(By.XPath("//*[@id='contactFormMessage']"));
            Enquiry.SendKeys("Toys");
        }
        public void Submit()
        {
            IWebElement Submitbtn = BaseClass.Driver.FindElement(By.XPath("//input[@type='submit'and @value='submit']"));
            Submitbtn.Click();

            // SreenShot
            ((ITakesScreenshot)BaseClass.Driver).GetScreenshot().SaveAsFile("Test.Png", ScreenshotImageFormat.Png);
        }

        
        public void verifymessage()
        {
            bool visible = true;
            IWebElement message = BaseClass.Driver.FindElement(By.XPath("//*[@id='contact_form']/p"));
            visible = message.Displayed;
            Assert.AreEqual(visible, true);
        }
        


    }
}
