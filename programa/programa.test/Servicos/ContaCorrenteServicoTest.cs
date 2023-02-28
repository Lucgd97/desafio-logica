using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Programa.Models;
using Programa.Servicos;

namespace Programa.Test.Models;

[TestClass]
public class ContaCorrenteServicoTest
{
    private ContaCorrenteServico contaCorrenteServico = new ContaCorrenteServico(new JsonDriver<ContaCorrente>(Environment.GetEnvironmentVariable("LOCAL_GRAVACAO_TEST_DESAFIO_DOTNET7") ?? "/tmp"));

    #region Metodos de setup test
    [TestInitialize()]
    public async Task Startup()
    {        
        //Console.WriteLine("========== [Antes do teste] ==========");
        await contaCorrenteServico.Persistencia.ExcluirTudo();
    }

    [TestCleanup()]
    public void Cleanup()
    {
        //ContaCorrenteServico.Get().Lista = new List<ContaCorrente>();antes de injecao de dependencia
        //Console.WriteLine("========== [Depois do teste] ==========");
    }
    #endregion

    #region  Metodos helpers
    private async Task criarDadosContaFake(string idCliente, double[]valores)
    {
        foreach(var valor in valores)
        {
            await contaCorrenteServico.Persistencia.Salvar(new ContaCorrente(){
            Id = Guid.NewGuid().ToString(),    
            IdCliente = idCliente,
            Valor = valor,
            Data = DateTime.Now
        });
        }       
    }
    #endregion

    [TestMethod]
    public void TestandoInjecaoDeDependencia(){
                
        // testar get (public or private)
        var contaCorrenteServicoJson = new ContaCorrenteServico(new JsonDriver<ContaCorrente>("bla"));
        Assert.IsNotNull(contaCorrenteServicoJson);
        Assert.IsNotNull(contaCorrenteServicoJson.Persistencia);

        var contaCorrenteServicoCsv = new ContaCorrenteServico(new CsvDriver<ContaCorrente>("bla"));
        Assert.IsNotNull(contaCorrenteServicoCsv);
        Assert.IsNotNull(contaCorrenteServicoCsv.Persistencia);
        
    }

    [TestMethod]
    public async Task TestandoRetornoDoExtrato(){
        
        //Console.WriteLine("========== [TestandoRetornoDoExtrato] ==========");
        // Preparacao (Arrange)
        var idCliente = Guid.NewGuid().ToString();
        await criarDadosContaFake(idCliente, new double[] {100.5, 10});
        
        // Processamento dados (Act)
        var extrato = await contaCorrenteServico.ExtratoCliente(idCliente);            
        

        //validacao (Assert)
        Assert.AreEqual(2, extrato.Count);
        
    }

    [TestMethod]
    public async Task TestandoRetornoDoExtratoComQuantidadeAMais(){
        
        //Console.WriteLine("========== [TestandoRetornoDoExtratoComQuantidadeAMais] ==========");
        // Preparacao (Arrange)
        var idCliente = Guid.NewGuid().ToString();
        await criarDadosContaFake(idCliente, new double[] {100.01, 50});
       
        var idCliente2 = Guid.NewGuid().ToString();
        await criarDadosContaFake(idCliente2, new double[] {40});   
         
        // Processamento dados (Act)
        var extrato = await contaCorrenteServico.ExtratoCliente(idCliente2);            
        
        //validacao (Assert)
        Assert.AreEqual(1, extrato.Count);
        Assert.AreEqual(3, (await contaCorrenteServico.Persistencia.Todos()).Count);
        
    }

    [TestMethod]
    public async Task TestandoSaldoDeUmCliente(){
        
        //Console.WriteLine("========== [TestandoRetornoDoExtratoComQuantidadeAMais] ==========");
        // Preparacao (Arrange)
        var IdCliente = Guid.NewGuid().ToString();
        await criarDadosContaFake(IdCliente, new double[] {5, 5, 5, -10});
        await criarDadosContaFake(Guid.NewGuid().ToString(), new double[] {300, 45});
              
        // Processamento dados (Act)
        var saldo = await contaCorrenteServico.SaldoCliente(IdCliente);            
        
        //validacao (Assert)
        Assert.AreEqual(5, saldo);
        Assert.AreEqual(6, (await contaCorrenteServico.Persistencia.Todos()).Count);
        
    }
    
}

