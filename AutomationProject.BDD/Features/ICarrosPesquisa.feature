
Feature: ICarrosPesquisa
	Eu como cliente interessado em comprar um veículo,
	desejo pesquisar por veiculos novos, usados e com financiamento 
	e visualizar os veiculos disponíveis no sistema.

Background: 
	Given Que estou na tela de consulta de veiculos
	

Scenario Outline: Pesquisar veiculos para compra 
	And que o usuario informe os seguintes filtros: <TipoVeiculo>, <SituacaoVeiculo>, <MarcaVeiculo>,<ModeloVeiculo>, <CidadeVeiculo>, <PrecoDe>, <PrecoAte>,<AnoDe>,<AnoAte>
	Then clico em buscar
	When o sistema apresenta a listagem de veículos
	Examples: 
	| TipoVeiculo | SituacaoVeiculo | MarcaVeiculo | ModeloVeiculo | CidadeVeiculo  | PrecoDe | PrecoAte | AnoDe | AnoAte |
	| Carro       | Novo            | Fiat         | Palio         | Belo Horizonte | 0       | 20.000   | 2000  | 2018   |
	| Carro       | Usado            | Volkswagem         | Gol         | Belo Horizonte | 0       | 20.000   | 2000  | 2018   |
	| Carro       | Novo            | Ford         | Fiesta         | Belo Horizonte | 0       | 20.000   | 2000  | 2018   |



