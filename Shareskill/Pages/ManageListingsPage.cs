using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using Shareskill.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shareskill.Pages
{
    class ManageListingsPage
    {
        public ManageListingsPage()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        
        #region Initialize Web Elements
        //Click Manage Listings tab
        [FindsBy(How = How.XPath, Using = "//a[@href='/Home/ListingManagement']")]
        private IWebElement ManageListingsbtn { get; set; }
        //Click on View Service
        [FindsBy(How = How.XPath, Using = "//td[text()='Software Tester']//following-sibling::td[@class='one wide']//child::i[@class='eye icon']")]
        private IWebElement Viewicon { get; set; }
        //Click on Edit Service
        [FindsBy(How = How.XPath, Using = "//td[text()='Software Tester']//following-sibling::td[@class='one wide']//child::i[@class='outline write icon']")]
        private IWebElement Writeicon { get; set; }
        //Click on Delete Service
        [FindsBy(How = How.XPath, Using = "//td[text()='Software Tester']//following-sibling::td[@class='one wide']//child::i[@class='remove icon']")]
        private IWebElement Removeicon { get; set; }
        //ConfirmDelete button
        [FindsBy(How = How.XPath, Using = "//button[@class='ui icon positive right labeled button']")]
        private IWebElement ConfirmDeletebtn { get; set; }
        #endregion
        internal void ManageListings()
        {
            ManageListingsbtn.Click();
            Viewicon.Click();
            Base.test.Log(LogStatus.Info, "Can view Skill successfully");
            ManageListingsbtn.Click();
            Writeicon.Click();
            ManageListingsbtn.Click();
            Removeicon.Click();
            ConfirmDeletebtn.Click();
            Base.test.Log(LogStatus.Info, "Skill deleted successfully");

        }
    }
}
