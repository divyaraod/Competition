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
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add new tag']")]
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

            //Click on Share Skill button
            ShareSkillbtn.Click();
            GlobalDefinitions.wait(10);
            //Enter the Title
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            //Enter the Description
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            //Choose Category
            CategoryId.Click();
            switch (GlobalDefinitions.ExcelLib.ReadData(2, "CategoryId"))
            {
                case "Graphics & Design":
                    GraphicsDesignCategory.Click();
                    switch (GlobalDefinitions.ExcelLib.ReadData(2, "SubcategoryId"))
                    {
                        case "Logo Design":
                            LogoDesignsubcategory.Click();
                            break;
                        case "Book & Album covers":
                            BookandAlbumcoversubcategory.Click();
                            break;
                        case "Flyers & Brochures":
                            FlyersBrochuressubcategory.Click();
                            break;
                        case "Web & Mobile Design":
                            WebMobileDesignsubcategory.Click();
                            break;
                        case "Search & Display Marketing":
                            SearchDisplayMarketingsubcategory.Click();
                            break;
                        
                    }
                    break;
                case "Digital Marketing":
                    DigitalMarketingCategory.Click();
                    switch (GlobalDefinitions.ExcelLib.ReadData(2, "SubcategoryId"))
                    {
                        case "Social Media Marketing":
                            SocialMediaMarketingsubcategory.Click();
                            break;
                        case "Content Marketing":
                            ContentMarketingsubcategory.Click();
                            break;
                        case "Video Marketing":
                            VideoMarketingsubcategory.Click();
                            break;
                        case "Email Marketing":
                            EmailMarketingsubcategory.Click();
                            break;
                        case "Search & Display Marketing":
                            SearchandDisplayMarketing2subcategory.Click();
                            break;

                    }
                    break;
                case "Writing & Translation":
                    WritingTranslationCategory.Click();
                    switch (GlobalDefinitions.ExcelLib.ReadData(2, "SubcategoryId"))
                    {
                        case "Resumes & Cover Letters":
                            ResumesandCoverLettersubcategory.Click();
                            break;
                        case "Proof Reading & Editing":
                            ProofReadingandEditingsubcategory.Click();
                            break;
                        case "Translation":
                            Translationsubcategory.Click();
                            break;
                        case "Creative Writing":
                            CreativeWritingsubcategory.Click();
                            break;
                        case "Business Copywriting":
                            BusinessandCopywritingsubcategory.Click();
                            break;
                    }
                    break;
                case "Video & Animation":
                    VideoAnimationCategory.Click();
                    switch (GlobalDefinitions.ExcelLib.ReadData(2, "SubcategoryId"))
                    {
                        case "Promotional Videos":
                            PromotionalVideossubcategory.Click();
                            break;
                        case "Editing & Post Production":
                            EditingandPostProductionsubcategory.Click();
                            break;
                        case "Lyric & Music Videos":
                            LyricandMusicVideossubcategory.Click();
                            break;
                        case "Other":
                            Othersubcategory.Click();
                            break;
                        
                    }
                    break;
                case "Music & Audio":
                    MusicAudioCategory.Click();
                    switch (GlobalDefinitions.ExcelLib.ReadData(2, "SubcategoryId"))
                    {
                        case "Mixing & Mastering":
                            MixingandMasteringsubcategory.Click();
                            break;
                        case "Voice Over":
                            VoiceOversubcategory.Click();
                            break;
                        case "Song Writers & Composers":
                            SongWritersandComposerssubcategory.Click();
                            break;
                        case "Other":
                            Other2subcategory.Click();
                            break;

                    }
                    break;
                case "Programming & Tech":
                    ProgrammingTechCategory.Click();
                    switch (GlobalDefinitions.ExcelLib.ReadData(2, "SubcategoryId"))
                    {
                        case "WordPress":
                            WordPresssubcategory.Click();
                            break;
                        case "Web & Mobile App":
                            WebandMobileAppsubcategory.Click();
                            break;
                        case "Data Analysis & Reports":
                            DataAnalysisandReportssubcategory.Click();
                            break;
                        case "QA":
                            QAsubcategory.Click();
                            break;
                        case "Databases":
                            Databasessubcategory.Click();
                            break;
                        case "Other":
                            Other3subcategory.Click();
                            break;

                    }
                    break;
                case "Business":
                    BusinessCategory.Click();
                    switch (GlobalDefinitions.ExcelLib.ReadData(2, "SubcategoryId"))
                    {
                        case "Business Tips":
                            BusinessTipssubcategory.Click();
                            break;
                        case "Presentations":
                            Presentationssubcategory.Click();
                            break;
                        case "Market Advice":
                            MarketAdvicesubcategory.Click();
                            break;
                        case "Legal Consulting":
                            LegalConsultingsubcategory.Click();
                            break;
                        case "Financial Consulting":
                            FinancialConsultingsubcategory.Click();
                            break;
                        case "Other":
                            Other4subcategory.Click();
                            break;
                    }
                    break;
                case "Fun & Lifestyle":
                    FunLifestyleCategory.Click();
                    switch (GlobalDefinitions.ExcelLib.ReadData(2, "SubcategoryId"))
                    {
                        case "Online Lessons":
                            OnlineLessonssubcategory.Click();
                            break;
                        case "Relationship Advice":
                            RelationshipAdvicesubcategory.Click();
                            break;
                        case "Astrology":
                            Astrologysubcategory.Click();
                            break;
                        case "Health, Nutrition & Fitness":
                            HealthNutritionandFitnesssubcategory.Click();
                            break;
                        case "Gaming":
                            Gamingsubcategory.Click();
                            break;
                        case "Other":
                            Other5subcategory.Click();
                            break;
                    }
                    break;
            }
           
            //Enter Tags
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);
            Tags.SendKeys(Keys.Tab);
            //Choose Service Type
            switch (GlobalDefinitions.ExcelLib.ReadData(2, "Service Type"))
            {
                case "Hourlybasis":
                    HourlybasisServiceButton.Click();
                    Base.test.Log(LogStatus.Info, "Hourly basis service is selected");
                    break;
                case "One-off":
                    OneoffServiceButton.Click();
                    Base.test.Log(LogStatus.Info, "One-off service is selected");
                    break;
            }
            
            //Choose Location Type
            switch (GlobalDefinitions.ExcelLib.ReadData(2, "Location Type"))
            {
                case "On-site":
                    OnsiteButton.Click();
                    Base.test.Log(LogStatus.Info, "Onsite location type is selected");
                    break;
                case "Online":
                    OnlineButton.Click();
                    Base.test.Log(LogStatus.Info, "Online location type is selected");
                    break;
            }
            //Enter Dates
            StartDate.Click();
            GlobalDefinitions.wait(10);
            StartDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartDate"));
            EndDate.Click();
            GlobalDefinitions.wait(10);
            EndDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndDate"));
            Day.Click();
            GlobalDefinitions.wait(10);
            //Enter Time
            StartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));
            EndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));
            //Choose Skill-Exchnage
            switch (GlobalDefinitions.ExcelLib.ReadData(2, "Skill Trade"))
            {
                case "Skill-exchange":
                    SkillExchangebutton.Click();
                    Base.test.Log(LogStatus.Info, "Skill-exchange is selected");
                    SkillTag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skills"));
                    Tags.SendKeys(Keys.Enter);
                    Tags.SendKeys(Keys.Tab);
                    break;
                case "Credit":
                    Creditbutton.Click();
                    Base.test.Log(LogStatus.Info, "Credit is selected");
                    Credit.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));
                    break;
            }
            
            WorkSample.Click();
            Thread.Sleep(1000);
            
            //Uploading file using AutoIt tool
            Process.Start("D:\\Test_Automation\\Shareskill\\FileUpload.exe");
            Base.test.Log(LogStatus.Info, "Uploaded file successfully");
            //Choose State
            switch (GlobalDefinitions.ExcelLib.ReadData(2, "State"))
            {
                
                case "Active":
                    GlobalDefinitions.wait(60);
                    Activebutton.Click();
                    Base.test.Log(LogStatus.Info, "Active state is selected");
                    break;
                case "Hidden":
                    Hiddenbutton.Click();
                    Base.test.Log(LogStatus.Info, "Hidden state is selected");
                    break;
            }
            
            Savebtn.Click();
            Base.test.Log(LogStatus.Info, "Added Skill successfully");
        }

       
    }
}
