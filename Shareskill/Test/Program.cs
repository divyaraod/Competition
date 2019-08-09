using NUnit.Framework;
using Shareskill.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shareskill
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class Skill : Global.Base
        {

            [Test]
            public void UserSkill()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Add skills to ShareSkill Page");

                // Create an class and object to call the method
                ShareskillPage obj = new ShareskillPage();
                obj.AddService();
                ManageListingsPage obj1 = new ManageListingsPage();
                obj1.ManageListings();

            }
        }
    }
}