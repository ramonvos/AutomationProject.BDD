using AutomationSeleniumSolution;
using AutomationSeleniumSolution.SeleniumBase;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.Selenium.PageObjects
{
    public class ICarrosDetalharVeiculoPage
    {
        public ICarrosDetalharVeiculoPage()
        {
            PageFactory.InitElements(DriverFactory.Instance, this);
        }

        [FindsBy(How = How.XPath, Using = "//a/p")]
        public IWebElement detalharVeiculo { get; set; }


        public void clicarDetalharVeiculo()
        {
            detalharVeiculo.Click();
        }
    
    }
}
