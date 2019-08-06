using Microsoft.JScript;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using Shareskill.Global;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shareskill.Pages
{
    class ShareskillPage
    {
        public ShareskillPage()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        #region Initialize Web Elements

        //Click on Share Skill button
        [FindsBy(How = How.XPath, Using = "//a[@href='/Home/ServiceListing']")]
        private IWebElement ShareSkillbtn { get; set; }
        //Click on Title
        [FindsBy(How = How.XPath, Using = "//input[@name='title']")]
        private IWebElement Title { get; set; }
        //Click on Description
        [FindsBy(How = How.XPath, Using = "//textarea[@name='description']")]
        private IWebElement Description { get; set; }
        //Click on Category
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']")]
        private IWebElement CategoryId { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Programming & Tech']")]
        private IWebElement Choosecategory { get; set; }
        //Click on Subcategory
        [FindsBy(How = How.XPath, Using = "//select[@name='subcategoryId']")]
        private IWebElement SubcategoryId { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='QA']")]
        private IWebElement Choosesubcategory { get; set; }
        //Click on Tags
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add new tag']")]
        private IWebElement Tags { get; set; }
        //Click on Service Type
        [FindsBy(How = How.XPath, Using = "//input[@name='serviceType' and @value='0']")]
        private IWebElement ServiceType { get; set; }
        //Click on Location Type
        [FindsBy(How = How.XPath, Using = "//input[@name='locationType' and @value='1']")]
        private IWebElement LocationType { get; set; }
        //Click on Start Date
        [FindsBy(How = How.XPath, Using = "//input[@name='startDate']")]
        private IWebElement StartDate { get; set; }
        //Click on End Date
        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']")]
        private IWebElement EndDate { get; set; }
        //Select Day
        [FindsBy(How = How.XPath, Using = "//input[@name='Available' and @index='1']")]
        private IWebElement Day { get; set; }
        //Select Time
        [FindsBy(How = How.XPath, Using = "//input[@name='StartTime' and @index='1']")]
        private IWebElement StartTime { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='EndTime' and @index='1']")]
        private IWebElement EndTime { get; set; }
        //Select Skill Trade
        [FindsBy(How = How.XPath, Using = "//input[@name='skillTrades' and @value='false']")]
        private IWebElement SkillTrade { get; set; }
        //Select Credit
        [FindsBy(How = How.XPath, Using = "//input[@name='charge']")]
        private IWebElement Credit { get; set; }
        //Add Work Samples
        [FindsBy(How = How.XPath, Using = "//i[@class='huge plus circle icon padding-25']")]
        //[FindsBy(How = How.XPath, Using = "//div[@class='ui grid']")]

        private IWebElement WorkSample { get; set; }
        //Select Active
        [FindsBy(How = How.XPath, Using = "//input[@name='isActive' and @value='true']")]
        private IWebElement Active { get; set; }
        //Click Save
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Savebtn { get; set; }
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
        internal void AddService()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            
            GlobalDefinitions.wait(10);

            //Click on Share Skill button
            ShareSkillbtn.Click();
           
            GlobalDefinitions.wait(10);
            //Enter the Title
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            //Enter the Description
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            CategoryId.Click();
            Choosecategory.Click();
            SubcategoryId.Click();
            Choosesubcategory.Click();
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);
            Tags.SendKeys(Keys.Tab);
            ServiceType.Click();
            LocationType.Click();
            
            StartDate.Click();
            Thread.Sleep(1000);
            StartDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartDate"));
            EndDate.Click();
            Thread.Sleep(1000);
            EndDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndDate"));
            Day.Click();
            Thread.Sleep(1000);
            StartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));
            EndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));
            SkillTrade.Click();
            Credit.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));
            WorkSample.Click();
            Thread.Sleep(10000);
            //Uploading file using AutoIt tool
            Process.Start("D:\\Test_Automation\\Shareskill\\FileUpload.exe");
            
            Active.Click();
            Thread.Sleep(1000);
            Savebtn.Click();
            Thread.Sleep(1000);
            Base.test.Log(LogStatus.Info, "Added Skill successfully");
        }

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
