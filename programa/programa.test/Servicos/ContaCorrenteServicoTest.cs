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
    #region Metodos de setup test
    [TestInitialize()]
    public void Startup()
    {
        //Console.WriteLine("========== [Antes do teste] ==========");
        ContaCorrenteServico.Get().Lista = new List<ContaCorrente>();
    }

    [TestCleanup()]
    public void Cleanup()
    {
        ContaCorrenteServico.Get().Lista = new List<ContaCorrente>();
        //Console.WriteLine("========== [Depois do teste] ==========");
    }
    #endregion

    #region  Metodos helpers
    private void criarDadosContaFake(string idCliente, double[]valores)
    {
        foreach(var valor in valores)
        {
            ContaCorrenteServico.Get().Lista.Add(new ContaCorrente(){
            Id = Guid.NewGuid().ToString(),    
            IdCliente = idCliente,
            Valor = valor,
            Data = DateTime.Now
        });
        }       
    }
    #endregion
        
    [TestMethod]
    public void TestandoUnicaInstanciaDoServico(){
        
        // Console.WriteLine("========== [TestandoUnicaInstanciaDoServico] ==========");        
        // testar get (public or private)
        Assert.IsNotNull(ContaCorrenteServico.Get());
        Assert.IsNotNull(ContaCorrenteServico.Get().Lista);

        // test de lista
        ContaCorrenteServico.Get().Lista.Add(new ContaCorrente(){
            Id = Guid.NewGuid().ToString(),
            IdCliente = "2122222"
            });            
        
        Assert.AreEqual(1, ContaCorrenteServico.Get().Lista.Count);
        
    }

    [TestMethod]
    public void TestandoRetornoDoExtrato(){
        
        //Console.WriteLine("========== [TestandoRetornoDoExtrato] ==========");
        // Preparacao (Arrange)
        var idCliente = Guid.NewGuid().ToString();
        criarDadosContaFake(idCliente, new double[] {100.5, 10});
        
        // Processamento dados (Act)
        var extrato = ContaCorrenteServico.Get().ExtratoCliente(idCliente);            
        

        //validacao (Assert)
        Assert.AreEqual(2, extrato.Count);
        
    }

    [TestMethod]
    public void TestandoRetornoDoExtratoComQuantidadeAMais(){
        
        //Console.WriteLine("========== [TestandoRetornoDoExtratoComQuantidadeAMais] ==========");
        // Preparacao (Arrange)
        var idCliente = Guid.NewGuid().ToString();
        criarDadosContaFake(idCliente, new double[] {100.01, 50});
       
        var idCliente2 = Guid.NewGuid().ToString();
         criarDadosContaFake(idCliente2, new double[] {40});   
         
        // Processamento dados (Act)
        var extrato = ContaCorrenteServico.Get().ExtratoCliente(idCliente2);            
        
        //validacao (Assert)
        Assert.AreEqual(1, extrato.Count);
        Assert.AreEqual(3, ContaCorrenteServico.Get().Lista.Count);
        
    }

    [TestMethod]
    public void TestandoSaldoDeUmCliente(){
        
        //Console.WriteLine("========== [TestandoRetornoDoExtratoComQuantidadeAMais] ==========");
        // Preparacao (Arrange)
        var IdCliente = Guid.NewGuid().ToString();
        criarDadosContaFake(IdCliente, new double[] {5, 5, 5, -10});
        criarDadosContaFake(Guid.NewGuid().ToString(), new double[] {300, 45});
              
        // Processamento dados (Act)
        var saldo = ContaCorrenteServico.Get().SaldoCliente(IdCliente);            
        
        //validacao (Assert)
        Assert.AreEqual(5, saldo);
        Assert.AreEqual(6, ContaCorrenteServico.Get().Lista.Count);
        
    }
    
}

