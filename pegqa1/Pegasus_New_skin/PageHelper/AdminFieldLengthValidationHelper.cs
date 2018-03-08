﻿/*
* AdminFieldLengthValidationHelper.cs is linked to AdminFieldLengthValidation.cs and
* AdminFieldLengthValidation.xml
*
*/


using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using PegasusTests.PageHelper.Comm;
using OpenQA.Selenium.Support.UI;
using PegasusTests.Locators;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PegasusTests.PageHelper
{
    public class AdminFieldLengthValidationHelper : DriverHelper
    {
        public LocatorReader locatorReader;

        public AdminFieldLengthValidationHelper(IWebDriver idriver)
            : base(idriver)
        {
            locatorReader = new LocatorReader("AdminFieldLengthValidation.xml");
        }

        //Click to given xml node
        public void ClickElement(string XmlNode)
        {
            String locator = locatorReader.ReadLocator(XmlNode);
            Click(locator);
        }
        internal void MouseHover(string field)
        {
            var locator = locatorReader.ReadLocator(field);
            WaitForElementPresent(locator, 20);
            MouseOver(locator);
        }
        public bool ElementVisible(string field)
        {
            var locator = locatorReader.ReadLocator(field);
            return IsElementPresent(locator);
        }

        // Type into given xml node
        public void TypeText(string Field, string text)
        {
            var locator = locatorReader.ReadLocator(Field);
            WaitForElementPresent(locator, 20);
            WaitForElementEnabled(locator, 20);
            SendKeys(locator, text);
        }

        public bool VerifyText(string XmlNode, string text)
        {
            var locator = locatorReader.ReadLocator(XmlNode);


            return locator.Contains(text);  
        }
    }
}