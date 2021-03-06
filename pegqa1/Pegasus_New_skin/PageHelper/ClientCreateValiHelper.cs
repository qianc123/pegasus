﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using PegasusTests.Locators;
using PegasusTests.PageHelper.Comm;
namespace PegasusTests.PageHelper
{
    class ClientCreateValiHelper : DriverHelper
    {
        public LocatorReader locatorReader;
        public ClientCreateValiHelper(IWebDriver idriver)
            : base(idriver)
        {
            locatorReader = new LocatorReader("ClientCreateVali.xml");
        }
        public void TypeText(string Field, string text)
        {
            var locator = locatorReader.ReadLocator(Field);
            WaitForElementPresent(locator, 20);
            SendKeys(locator, text);
        }
        public void ClearText(string Field)
        {
            var locator = locatorReader.ReadLocator(Field);
            ClearTextBoxValue(locator);

        }
        public string GetTextContent(string xmlnode)
        {
            var locator = locatorReader.ReadLocator(xmlnode);
            return getInputText(locator);
        }
        public string GetAtrribute(string Field, string attribute)
        {
            var locator = locatorReader.ReadLocator(Field);
            return GetAtrributeByLocator(locator, attribute);
        }
        public void verifyElementPresent(string field)
        {
            var locator = locatorReader.ReadLocator(field);
            WaitForElementPresent(locator, 30);
            Assert.IsTrue(IsElementPresent(locator));
        }
        public void Select(string xmlNode, string value)
        {
            var locator = locatorReader.ReadLocator(xmlNode);
            SelectDropDown(locator, value);
        }

        public void SelectByText(string xml ,string text)
        {
            var locator = locatorReader.ReadLocator(xml);
            WaitForElementPresent(xml ,10);
            SelectDropDownByText(locator ,text);
            WaitForWorkAround(2000);
        }

        public void ClickElement(string xmlNode)
        {
            WaitForWorkAround(3000);
            var locator = locatorReader.ReadLocator(xmlNode);
            WaitForElementPresent(locator, 50);
            Click(locator);
            WaitForWorkAround(3000);
        }
        public bool checkSelected(string xmlNode)
        {
            var locator = locatorReader.ReadLocator(xmlNode);
            return isChecked(locator);
        }
    }
}