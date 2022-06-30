using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace BigSmall.Utilites
{
    [Binding]
  public  class BaseClass
  {
        public static ExtentReports extents;
        public static ExtentTest feature;
        public static ExtentTest scenario;
        public static IWebDriver Driver;

        [BeforeFeature]
        public static void featureBrowser(FeatureContext featurecontext)
        {
            feature = extents.CreateTest<Feature>(featurecontext.FeatureInfo.Title);
        }

        [BeforeScenario]
        public static void LaunchBrowser(ScenarioContext scenarioContext)
        {
            scenario = feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.bigsmall.in/");
          

        }

        [BeforeTestRun]
        public static void GenerateReport()
        {
            var htmlReport = new ExtentHtmlReporter(@"C:\Users\mindtreejanedge220\Desktop\CaseStudy\BigSmall\BigSmall\Index.html");
            htmlReport.Config.Theme =AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extents = new ExtentReports();
            extents.AttachReporter(htmlReport);
        }

        [AfterTestRun]
        public static void CloseExtentReport()
        {
            extents.Flush();
        }

        [AfterStep]
        public static void InsertReportingSteps(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TestError == null)
            {
                var stepType =ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")

                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "When")

                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "Then")

                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "And")

                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }

            if (scenarioContext.TestError != null)
            {
                var stepType =ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")

                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
                if (stepType == "When")

                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
                if (stepType == "Then")

                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
                if (stepType == "And")

                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
            }
        }

        [AfterScenario]

        public static void close()
        {
           Driver.Quit();
        }
  }
}
