using System;
using TechTalk.SpecFlow;

namespace AutomationProject.BDD
{
    [Binding]
    public class ICarrosPesquisaSteps
    {
        [Given(@"Que estou na tela de consulta de veiculos")]
        public void GivenQueEstouNaTelaDeConsultaDeVeiculos()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"que o usuario informe os seguintes filtros")]
        public void GivenQueOUsuarioInformeOsSeguintesFiltros()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"informo o tipo, a marca, o modelo, o ano inicial, e ano final")]
        public void GivenInformoOTipoAMarcaOModeloOAnoInicialEAnoFinal()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"o sistema apresenta a listagem de veículos")]
        public void WhenOSistemaApresentaAListagemDeVeiculos()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"clico em buscar")]
        public void ThenClicoEmBuscar()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
