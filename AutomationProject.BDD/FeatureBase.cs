using AutomationProject.Selenium.PageObjects;
using AutomationSeleniumSolution;
using AutomationSeleniumSolution.ExtentReportLogger;
using AutomationSeleniumSolution.SeleniumBase;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomationProject.BDD
{
    public class FeatureBase
    {
        private ProxyGenerator ProxyGenerator;

        public FeatureBase()
        {
           this.ProxyGenerator = new ProxyGenerator();
            if (DriverFactory.Instance == null)
            {
                DriverFactory.Initialize(ConfigurationManager.AppSettings["Browser"]);
                Reporter.CreateReport();
            }
            InjectPageObjects(CollectPageObjects(), null);
            
        }


        private void InjectPageObjects(List<FieldInfo> fields, IInterceptor proxy)
        {
            foreach (FieldInfo field in fields)
            {
                field.SetValue(this, ProxyGenerator.CreateClassProxy(field.FieldType, proxy));
            }
        }

        private List<FieldInfo> CollectPageObjects()
        {
            List<FieldInfo> fields = new List<FieldInfo>();

            foreach (FieldInfo field in this.GetType().GetRuntimeFields())
            {
                if (field.GetCustomAttribute(typeof(PageObject)) != null)
                    fields.Add(field);
            }

            return fields;
        }


        public static string actualTest = string.Empty;
        [BeforeScenario]
        public void ScenarioSetup()
        {
            //Reporter.CreateReport();
        }
        [Before]
        public void BeforeStep()
        {
            //var aux = ScenarioContext.Current.ScenarioInfo.Title;

            //if (actualTest != aux)
            //{
            //    Reporter.AddFeature();
            //    Reporter.AddScenario();
            //}
            Reporter.AddFeature();
            Reporter.AddScenario();

        }
        //[BeforeFeature]
        //public void SetupFeature()
        //{

        //    log.AddFeature();
        //}

        //[BeforeScenario]
        //public void SetUpScenario()
        //{
        //    log.AddScenario();
        //}
        //[AfterScenario]
        //public void ScenarioTearDown()
        //{
        //    Reporter.GenerateReport();
        //    if (DriverFactory.Instance == null)
        //    {
        //        DriverFactory.Instance.Quit();
        //    }
        //}

        [After]
        public void AfterFeature()
        {
            Reporter.AddScreenShot();

            Reporter.GenerateReport();
           
            if (DriverFactory.Instance == null)
            {
                DriverFactory.Instance.Quit();
            }
        }
       

        [AfterStep]
        public void entreiaqui()
        {
            //Thread.Sleep(500);
        }

    }
}
