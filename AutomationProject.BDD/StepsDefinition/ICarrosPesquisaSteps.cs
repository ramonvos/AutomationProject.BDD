using AutomationProject.Selenium.PageObjects;
using System;
using System.Configuration;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AutomationProject.BDD.StepsDefinition
{
    [Binding]
    public class ICarrosPesquisaSteps : FeatureBase
    {
        [PageObject]
        SeminovosBHPesquisarPage page;
        [Given(@"Que estou na tela de consulta de veiculos")]
        public void GivenQueEstouNaTelaDeConsultaDeVeiculos()
        {
            string url = ConfigurationManager.AppSettings["UrlBase"];
            page.abrirPagina(url);
        }

        [Given(@"que o usuario informe os seguintes filtros: (.*), (.*), (.*), (.*), (.*), (.*), (.*),(.*),(.*)")]
        public void GivenQueOUsuarioInformeOsSeguintesFiltrosCarroNovoFiatPalioBeloHorizonte(string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8)
        {
            Console.WriteLine(p0);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.WriteLine(p5);
            Console.WriteLine(p6);
            Console.WriteLine(p7);
            Console.WriteLine(p8);
        }


        
        [When(@"o sistema apresenta a listagem de veículos")]
        public void WhenOSistemaApresentaAListagemDeVeiculos()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"clico em buscar")]
        public void ThenClicoEmBuscar()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
