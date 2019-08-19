using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using Shareskill.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            //Check if the skill is added Successfully
            //Check if Manage Listings tab is clickable
            ManageListingsbtn.Click();
            Base.test.Log(LogStatus.Info, "Manage Listings Tab is clicked");
            GlobalDefinitions.wait(10);
            Boolean isSkillPresent = GlobalDefinitions.driver.FindElements(By.XPath("//td[text()='Software Tester']")).Count > 0;
            if (isSkillPresent == true)
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Skill Added Successfully");
                
            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Skill Addition UnSuccessful");
            }

            //Check if user is able to view skill successfully
            Viewicon.Click();
            Boolean isSkillViewable = GlobalDefinitions.driver.FindElements(By.XPath("//div[@class='content']")).Count > 0;
            if (isSkillViewable == true)
            {
                Base.test.Log(LogStatus.Pass, "Skill is viewed successfully");
            }
            else
            {
                Base.test.Log(LogStatus.Fail, "Skill cant be viewed");
            }
            ManageListingsbtn.Click();

            //Check if user is able to click write icon of Skill
            Writeicon.Click();
            Base.test.Log(LogStatus.Pass, "write icon of skill is clicked");
            ManageListingsbtn.Click();

            //Check if user is able to delete skill
            //Check if user is able to click remove icon of Skill
            Removeicon.Click();
            Base.test.Log(LogStatus.Info, "remove icon of skill is clicked");
            ConfirmDeletebtn.Click();
            GlobalDefinitions.wait(50);
            Boolean isSkillDeleted = GlobalDefinitions.driver.FindElements(By.XPath("//td[text()='Programming & Tech']//following-sibling::td[text()='Software Tester']")).Count > 0;
            if (isSkillDeleted == true)
            {
                Base.test.Log(LogStatus.Pass, "Skill deleted successfully");
            }
            else
            {
                Base.test.Log(LogStatus.Fail, "Skill deletion UnSuccessful");
            }
        }
    }
}
