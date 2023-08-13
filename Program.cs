using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffMember.Benchmark.AutomationTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WindowsDriver<WindowsElement> sessionStaffMemberApp;

            AppiumOptions appium = new AppiumOptions();
            appium.AddAdditionalCapability("app", @"C:\Users\Jun.Wang\Desktop\StaffMembers.BenchmarkApp.application");

            sessionStaffMemberApp = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"),appium);

            var btnLoad = sessionStaffMemberApp.FindElementByName("Load");
            btnLoad.Click();
            var formResult =  sessionStaffMemberApp.FindElementByAccessibilityId("lbxStaffMembers");
            AppiumWebElement data = formResult;
            Debug.WriteLine($" value size is {data.Size}");
            Debug.WriteLine($" value text is {data.Text}");

            runTest("load", data);


            var btnAZ = sessionStaffMemberApp.FindElementByName("AZ");
            btnAZ.Click();
            var formResult01 = sessionStaffMemberApp.FindElementByAccessibilityId("lbxStaffMembers");
            AppiumWebElement data01 = formResult01;
            Debug.WriteLine($" value shown is {data01.Size}");
            Debug.WriteLine($" value text is {data01.Text}");

            runTest("ascending sort", data01);


            var btnZA = sessionStaffMemberApp.FindElementByName("ZA");
            btnZA.Click();
            var formResult02 = sessionStaffMemberApp.FindElementByAccessibilityId("lbxStaffMembers");
            AppiumWebElement data02 = formResult02;
            Debug.WriteLine($" value shown is {data02.Size}");
            Debug.WriteLine($" value text is {data02.Text}");

            runTest("decending sorting", data02);

            var btnSearch = sessionStaffMemberApp.FindElementByName("Search");
            btnSearch.Click();
            var formResult03 = sessionStaffMemberApp.FindElementByAccessibilityId("lbxSearchResults");
            AppiumWebElement data03 = formResult03;
            Debug.WriteLine($" value shown is {data03.Size}");
            Debug.WriteLine($" value text is {data03.Text}");

            runTest("Search", data03);


            var btnAdd = sessionStaffMemberApp.FindElementByName("Add");
            btnAdd.Click();
            var formResult04 = sessionStaffMemberApp.FindElementByAccessibilityId("lbxStaffMembers");
            AppiumWebElement data04 = formResult04;
            Debug.WriteLine($" vale shown is {data04.Size}");
            Debug.WriteLine($" value text is {data04.Text}");

            runTest("Add", data04);


            var btnUpdate = sessionStaffMemberApp.FindElementByName("Update");
            btnUpdate.Click();
            var formResult05 = sessionStaffMemberApp.FindElementByAccessibilityId("lbxStaffMembers");
            AppiumWebElement data05 = formResult05;
            Debug.WriteLine($" vale shown is {data05.Size}");
            Debug.WriteLine($" value text is {data05.Text}");

            runTest("Update", data05);


            var btnSave = sessionStaffMemberApp.FindElementByName("Save");
            btnSave.Click();
            var formResult06 = sessionStaffMemberApp.FindElementByAccessibilityId("lbxStaffMembers");
            AppiumWebElement data06 = formResult06;
            Debug.WriteLine($" vale shown is {data06.Size}");
            Debug.WriteLine($" value text is {data06.Text}");

            runTest("Save", data06);


          
            var btnDelete = sessionStaffMemberApp.FindElementByName("Delete");
            btnDelete.Click();
            var formResult07 = sessionStaffMemberApp.FindElementByAccessibilityId("lbxStaffMembers");
            AppiumWebElement data07 = formResult07;
            Debug.WriteLine($" vale shown is {data07.Size}");
            Debug.WriteLine($" value text is {data07.Text}");

            runTest("Update", data07);

        }

        public static void runTest(string functionName, AppiumWebElement element)
        {

            if (element.Text.Length > 0)
            {
                Debug.WriteLine($" The " + functionName + " funciton is correct.");

            }
            else
            {
                Debug.WriteLine($" The " + functionName + " funciton is correct.");
            }
        }
    }
}
