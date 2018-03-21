using AutomationSeleniumSolution;
using AutomationSeleniumSolution.ExtentReportLogger;
using AutomationSeleniumSolution.SeleniumBase;
using AutomationSeleniumSolution.SeleniumComponets;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationProject.Selenium.PageObjects
{
    public class SeminovosBHPesquisarPage
    {
        public SeminovosBHPesquisarPage()
        {
            PageFactory.InitElements(DriverFactory.Instance, this);
        }
       

        

        [FindsBy(How = How.XPath, Using = "//div[@id='boxselecao']/fieldset/label")]
        public IWebElement ckCarros { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='boxselecao']/fieldset/label[2]")]
        public IWebElement ckMotos { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@id='boxselecao']/fieldset/label[3]")]
        public IWebElement ckCaminhoes { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='simpleSearch']/div[2]/dl/dd/label")]
        public IWebElement ckZeroKm { get; set; }


        [FindsBy(How = How.XPath, Using = "//form[@id='simpleSearch']/div[2]/dl/dd/label[2]")]
        public IWebElement ckSeminovo { get; set; }


        [FindsBy(How = How.Id, Using = "marca")]
        public IWebElement ddlMarca { get; set; }


        [FindsBy(How = How.Id, Using = "modelo")]
        public IWebElement ddlModelo { get; set; }


        [FindsBy(How = How.Id, Using = "idCidade")]
        public IWebElement ddlCidade { get; set; }


        [FindsBy(How = How.Id, Using = "valor1")]
        public IWebElement ddlValorDe { get; set; }

        [FindsBy(How = How.Id, Using = "valor2")]
        public IWebElement ddlValorAte { get; set; }

        [FindsBy(How = How.Id, Using = "ano1")]
        public IWebElement ddlAnoInicial { get; set; }

        [FindsBy(How = How.Id, Using = "ano2")]
        public IWebElement ddlAnoFinal { get; set; }


        [FindsBy(How = How.Id, Using = "btn_enviar")]
        public IWebElement btnBuscar { get; set; }

        [FindsBy(How = How.Id, Using = "//form[@id='simpleSearch']/div[9]")]
        public IWebElement msgErroPesquisa { get; set; }

        

        public void abrirPagina(string url)
        {

            NavigationHelper.NavigateToPage(url);
        }


        public void IsAlertPresente()
        {
            Thread.Sleep(3000);
            try
            {
                IAlert alert = DriverFactory.Instance.SwitchTo().Alert();

                alert.Accept();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

       

        public void marcarCarros(bool zeroKm)
        {
            
            ckCarros.CheckedCheckBox(zeroKm);
            
            
        }
        public void marcarMotos(bool usados)
        {
            ckMotos.CheckedCheckBox(usados);
            
            
            
        }
        public void marcarComFinanciamento(bool possuiFinancimento)
        {
            ckCaminhoes.CheckedCheckBox(possuiFinancimento);
            
            
        }
        public void selecionarMarca(string marca)
        {
            ddlMarca.SelectElementByText(marca);
          

        }
        public void selecionarModelo(string modelo)
        {
            ddlModelo.SelectElementByText(modelo);
        }
        public void selecionarAnoDe(string ano)
        {
            ddlAnoInicial.SelectElementByText(ano);
        }
        public void selecionarAnoAte(string ano)
        {
            ddlAnoFinal.SelectElementByText(ano);
        }
        public void clicarBuscar()
        {
            ButtonHelper.ClickButton(btnBuscar);
            //Reporter.AddLogStep("buscar");
            //Thread.Sleep(3000);
        }

        public SeminovosBHPesquisarPage preencherPesquisa()
        {
            abrirPagina(DriverFactory.BaseUrl);

            marcarComFinanciamento(false);

            selecionarMarca("Fiat");
            selecionarModelo("Palio");
            selecionarAnoDe("2010");
            selecionarAnoAte("2017");

            clicarBuscar();

            return new SeminovosBHPesquisarPage();
        }

    }
}
