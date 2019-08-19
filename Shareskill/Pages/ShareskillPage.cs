using Microsoft.JScript;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using Shareskill.Global;
using AutoIt;
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
        //Redcolor prompt for error message
        [FindsBy(How = How.XPath, Using = "//div[@class='ui basic red prompt label transition visible']")]
        private IWebElement Invalid { get; set; }
        //Click on Title
        [FindsBy(How = How.XPath, Using = "//input[@name='title']")]
        private IWebElement Title { get; set; }
        //Click on Description
        [FindsBy(How = How.XPath, Using = "//textarea[@name='description']")]
        private IWebElement Description { get; set; }
        //Click on Category
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']")]
        private IWebElement CategoryId { get; set; }
        //Choose Category
        [FindsBy(How = How.XPath, Using = "//option[text()='Programming & Tech']")]
        private IWebElement ProgrammingTechCategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Graphics & Design']")]
        private IWebElement GraphicsDesignCategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Digital Marketing']")]
        private IWebElement DigitalMarketingCategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Writing & Translation']")]
        private IWebElement WritingTranslationCategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Music & Audio']")]
        private IWebElement MusicAudioCategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Business']")]
        private IWebElement BusinessCategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Fun & Lifestyle']")]
        private IWebElement FunLifestyleCategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Video & Animation']")]
        private IWebElement VideoAnimationCategory { get; set; }


        //Click on Subcategory
        [FindsBy(How = How.XPath, Using = "//select[@name='subcategoryId']")]
        private IWebElement SubcategoryId { get; set; }
        //Choose Subcategory for Graphics & Design Category
        [FindsBy(How = How.XPath, Using = "//option[text()='Logo Design']")]
        private IWebElement LogoDesignsubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Book & Album covers']")]
        private IWebElement BookandAlbumcoversubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Flyers & Brochures']")]
        private IWebElement FlyersBrochuressubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Web & Mobile Design']")]
        private IWebElement WebMobileDesignsubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Search & Display Marketing']")]
        private IWebElement SearchDisplayMarketingsubcategory { get; set; }
       
        //Choose Subcategory for Digital Marketing Category
        [FindsBy(How = How.XPath, Using = "//option[text()='Social Media Marketing']")]
        private IWebElement SocialMediaMarketingsubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Content Marketing']")]
        private IWebElement ContentMarketingsubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Video Marketing']")]
        private IWebElement VideoMarketingsubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Email Marketing']")]
        private IWebElement EmailMarketingsubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Search & Display Marketing']")]
        private IWebElement SearchandDisplayMarketing2subcategory { get; set; }

        //Choose Subcategory for Writing & Translation Category
        [FindsBy(How = How.XPath, Using = "//option[text()='Resumes & Cover Letters']")]
        private IWebElement ResumesandCoverLettersubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Proof Reading & Editing']")]
        private IWebElement ProofReadingandEditingsubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Translation']")]
        private IWebElement Translationsubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Creative Writing']")]
        private IWebElement CreativeWritingsubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Business & Copywriting']")]
        private IWebElement BusinessandCopywritingsubcategory { get; set; }

        //Choose Subcategory for Video & Animation Category
        [FindsBy(How = How.XPath, Using = "//option[text()='Promotional Videos']")]
        private IWebElement PromotionalVideossubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Editing & Post Production']")]
        private IWebElement EditingandPostProductionsubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Lyric & Music Videos']")]
        private IWebElement LyricandMusicVideossubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Other']")]
        private IWebElement Othersubcategory { get; set; }
        
        //Choose Subcategory for Music & Audio Category
        [FindsBy(How = How.XPath, Using = "//option[text()='Mixing & Mastering']")]
        private IWebElement MixingandMasteringsubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Voice Over']")]
        private IWebElement VoiceOversubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Song Writers & Composers']")]
        private IWebElement SongWritersandComposerssubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Other']")]
        private IWebElement Other2subcategory { get; set; }

        //Choose Subcategory for Programming & Tech Category
        [FindsBy(How = How.XPath, Using = "//option[text()='WordPress']")]
        private IWebElement WordPresssubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Web & Mobile App']")]
        private IWebElement WebandMobileAppsubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Data Analysis & Reports']")]
        private IWebElement DataAnalysisandReportssubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='QA']")]
        private IWebElement QAsubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Databases']")]
        private IWebElement Databasessubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Other']")]
        private IWebElement Other3subcategory { get; set; }

        //Choose Subcategory for Business Category
        [FindsBy(How = How.XPath, Using = "//option[text()='Business Tips']")]
        private IWebElement BusinessTipssubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Presentations']")]
        private IWebElement Presentationssubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Market Advice']")]
        private IWebElement MarketAdvicesubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Legal Consulting']")]
        private IWebElement LegalConsultingsubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Financial Consulting']")]
        private IWebElement FinancialConsultingsubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Other']")]
        private IWebElement Other4subcategory { get; set; }

        //Choose Subcategory for Fun & Lifestyle Category
        [FindsBy(How = How.XPath, Using = "//option[text()='Online Lessons']")]
        private IWebElement OnlineLessonssubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Relationship Advice']")]
        private IWebElement RelationshipAdvicesubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Astrology']")]
        private IWebElement Astrologysubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Health, Nutrition & Fitness']")]
        private IWebElement HealthNutritionandFitnesssubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Gaming']")]
        private IWebElement Gamingsubcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//option[text()='Other']")]
        private IWebElement Other5subcategory { get; set; }

        //Click on Tags
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add new tag']")]
        private IWebElement Tags { get; set; }
        
        //Click on Service Type
        [FindsBy(How = How.XPath, Using = "//input[@name='serviceType' and @value='0']")]
        private IWebElement HourlybasisServiceButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='serviceType' and @value='1']")]
        private IWebElement OneoffServiceButton { get; set; }
        
        //Click on Location Type
        [FindsBy(How = How.XPath, Using = "//input[@name='locationType' and @value='0']")]
        private IWebElement OnsiteButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='locationType' and @value='1']")]
        private IWebElement OnlineButton { get; set; }
       
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
        [FindsBy(How = How.XPath, Using = "//input[@name='skillTrades' and @value='true']")]
        private IWebElement SkillExchangebutton { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='skillTrades' and @value='false']")]
        private IWebElement Creditbutton { get; set; }
        //Select Skill-Exchange Tag
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillTag { get; set; }
        //Select Credit
        [FindsBy(How = How.XPath, Using = "//input[@name='charge']")]
        private IWebElement Credit { get; set; }
        //Add Work Samples
        [FindsBy(How = How.XPath, Using = "//i[@class='huge plus circle icon padding-25']")]
        private IWebElement WorkSample { get; set; }
        //Select Active
        [FindsBy(How = How.XPath, Using = "//input[@name='isActive' and @value='true']")]
        private IWebElement Activebutton { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='isActive' and @value='false']")]
        private IWebElement Hiddenbutton { get; set; }
        //Click Save
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Savebtn { get; set; }
        
        #endregion
        internal void AddService()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            GlobalDefinitions.wait(10);

            //Check if user is able to click on ShareSkill button
            ShareSkillbtn.Click();
            GlobalDefinitions.wait(10);
            Boolean isPresent = GlobalDefinitions.driver.FindElements(By.XPath("//input[@name='title']")).Count > 0;
            if(isPresent == true)
            {
                Base.test.Log(LogStatus.Pass, "Share Skill button is clicked Successfully");
            }
            else
            {
                Base.test.Log(LogStatus.Fail, "Share Skill button Click is UnSuccessful");
            }

            //Check if user is able to enter valid data as Title
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            //checking for invalid data
            Boolean isError = GlobalDefinitions.driver.FindElements(By.XPath("//div[@class='ui basic red prompt label transition visible']")).Count > 0;
            if(isError == true)
            {
                if(Invalid.Text == GlobalDefinitions.ExcelLib.ReadData(2, "Title Error Message"))
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Error displayed as expected: First character must be an alphabet character or a number");
                }
            }
            else
            {
                //Check if user is able to Enter Title
                Boolean isTitleFetched = GlobalDefinitions.driver.FindElements(By.XPath("//input[@value='Software Tester']")).Count > 0;
                if (isTitleFetched == true)
                {
                    Base.test.Log(LogStatus.Pass, "Title is Fetched from The Excel Successfully");
                }
                else
                {
                    Base.test.Log(LogStatus.Fail, "Title is not fetched correctly");
                }
            }


            //Check if user is able to enter valid data as description
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            //checking for invalid data
            if (isError == true)
            {
                if (Invalid.Text == GlobalDefinitions.ExcelLib.ReadData(2, "Title Error Message"))
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Error displayed as expected: Special characters are not allowed");
                }
            }
            //code for valid data
            else
            {
                if (Description.Text == GlobalDefinitions.ExcelLib.ReadData(2, "Description"))
                {
                    Base.test.Log(LogStatus.Pass, "Description is Fetched from The Excel Successfully");
                }
                else
                {
                    Base.test.Log(LogStatus.Fail, "Description is not fetched correctly");
                }
            }
           
            //Check if user is able to select Category
            CategoryId.Click();
            IList<IWebElement> Category = CategoryId.FindElements(By.TagName("option"));
            int categorycount = Category.Count;
            for (int i = 0; i < categorycount; i++)
            {
                if (Category[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "CategoryId"))
                {
                    Category[i].Click();
                    Base.test.Log(LogStatus.Pass, "Selected Category");
                    break;
                }
                else
                {
                    Base.test.Log(LogStatus.Info, "Cant find Category");
                }
            }

            //Check if user is able to choose Subcategory
            SubcategoryId.Click();
            IList<IWebElement> SubCategory = SubcategoryId.FindElements(By.TagName("option"));
            int subcategorycount = SubCategory.Count;
            for (int j = 0; j < subcategorycount; j++)
            {
                if (SubCategory[j].Text == GlobalDefinitions.ExcelLib.ReadData(2, "SubcategoryId"))
                {
                    SubCategory[j].Click();
                    Base.test.Log(LogStatus.Pass, "Selected Subcategory");
                    break;
                }
                else
                {
                    Base.test.Log(LogStatus.Info, "Cant find Subcategory");
                }
            }


            //Check if user is able to Enter valid tags
            Boolean isTagPresent = GlobalDefinitions.driver.FindElements(By.XPath("//span[contains(.,'test')]")).Count > 0;

            if (isTagPresent == true)
            {
                Base.test.Log(LogStatus.Info, "Tag already exists");
            }
            else
            {
                Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
                Tags.SendKeys(Keys.Enter);
                Tags.SendKeys(Keys.Tab);
                Base.test.Log(LogStatus.Pass, "Tag added successfully");
            }
            
            //Check if user is able to select Service Type
            switch (GlobalDefinitions.ExcelLib.ReadData(2, "Service Type"))
            {
                case "Hourlybasis":
                    HourlybasisServiceButton.Click();
                    Base.test.Log(LogStatus.Pass, "Hourly basis service is selected");
                    break;
                case "One-off":
                    OneoffServiceButton.Click();
                    Base.test.Log(LogStatus.Pass, "One-off service is selected");
                    break;
            }
            
            //Check if user is able to select Location Type
            switch (GlobalDefinitions.ExcelLib.ReadData(2, "Location Type"))
            {
                case "On-site":
                    OnsiteButton.Click();
                    Base.test.Log(LogStatus.Pass, "Onsite location type is selected");
                    break;
                case "Online":
                    OnlineButton.Click();
                    Base.test.Log(LogStatus.Pass, "Online location type is selected");
                    break;
            }
            
            //Check if user is able to enter valid Date
            StartDate.Click();
            GlobalDefinitions.wait(10);
            StartDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartDate"));
            //checking for invalid start date
             if (isError == true)
            {
                if (Invalid.Text == GlobalDefinitions.ExcelLib.ReadData(2, "Title Error Message"))
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Error displayed as expected: Start Date cannot be set to a day in the past");
                }
            }
            EndDate.Click();
            GlobalDefinitions.wait(10);
            EndDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndDate"));
            Day.Click();
            GlobalDefinitions.wait(10);
            
            //Check if user is able to select Time
            StartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));
            EndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));
            Base.test.Log(LogStatus.Pass, "Availability is selected");
           
            //Check if user is able to slect Skill-Trade
            switch (GlobalDefinitions.ExcelLib.ReadData(2, "Skill Trade"))
            {
                case "Skill-exchange":
                    SkillExchangebutton.Click();
                    Boolean isSkillTagPresent = GlobalDefinitions.driver.FindElements(By.XPath("//span[contains(.,'cooking')]")).Count > 0;
                    if (isTagPresent == true)
                    {
                        Base.test.Log(LogStatus.Info, "Tag already exists");
                    }
                    else
                    {
                        SkillTag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skills"));
                        SkillTag.SendKeys(Keys.Enter);
                        SkillTag.SendKeys(Keys.Tab);
                        Base.test.Log(LogStatus.Pass, "SkillTag is fetched successfully");
                    }
                    break;
                case "Credit":
                    Creditbutton.Click();
                    Base.test.Log(LogStatus.Info, "Credit is selected");
                    Credit.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));
                    Boolean isCreditFetched = GlobalDefinitions.driver.FindElements(By.XPath("//input[@value='10']")).Count > 0;
                    if (isCreditFetched == true)
                    {
                        Base.test.Log(LogStatus.Pass, "Credit is Fetched from The Excel Successfully");
                    }
                    else
                    {
                        Base.test.Log(LogStatus.Fail, "Credit is not fetched correctly");
                    }
                    break;
            }
            
            //Check if user is able to Upload worksample using AutoIt tool
            WorkSample.Click();
            Thread.Sleep(1000);
            AutoItX.WinActivate("Open");
            AutoItX.Send(GlobalDefinitions.ExcelLib.ReadData(2, "Upload File Path"));
            Thread.Sleep(1000);
            AutoItX.Send("{Enter}");
            Boolean isWorksampleUploaded = GlobalDefinitions.driver.FindElements(By.XPath("//a[text()='dd.txt']")).Count > 0;
            if (isWorksampleUploaded == true)
            {
                Base.test.Log(LogStatus.Pass, "Uploaded file successfully");
            }
            else
            {
                Base.test.Log(LogStatus.Fail, "File Updation Unsuccessful");
            }
            
            //Check if user is able to choose state
            switch (GlobalDefinitions.ExcelLib.ReadData(2, "State"))
            {
                
                case "Active":
                    GlobalDefinitions.wait(60);
                    Activebutton.Click();
                    Base.test.Log(LogStatus.Pass, "Active state is selected");
                    break;
                case "Hidden":
                    Hiddenbutton.Click();
                    Base.test.Log(LogStatus.Pass, "Hidden state is selected");
                    break;
            }
           
            //Check if user is able to click Save button
            Savebtn.Click();
            Base.test.Log(LogStatus.Pass, "Save button is clicked");
        }

       
    }
}
