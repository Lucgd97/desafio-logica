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
    
    
    [TestMethod]
    public void TestandoUnicaInstanciaDoServico(){

        Console.WriteLine("========== [TestandoUnicaInstanciaDoServico] ==========");        
        // testar get (public or private)
        Assert.IsNotNull(ContaCorrenteServico.Get());
        Assert.IsNotNull(ContaCorrenteServico.Get().Lista);

        // test de lista
        ContaCorrenteServico.Get().Lista.Add(new ContaCorrente(){
            IdCliente = "2122222"
            });            
        
        Assert.AreEqual(1, ContaCorrenteServico.Get().Lista.Count);
        
    }

    [TestMethod]
    public void TestandoRetornoDoExtrato(){
        
        Console.WriteLine("========== [TestandoRetornoDoExtrato] ==========");
        // Preparacao (Arrange)
        var IdCliente = Guid.NewGuid().ToString();
        ContaCorrenteServico.Get().Lista.Add(new ContaCorrente(){
            IdCliente = IdCliente,
            Valor = 100.01,
            Data = DateTime.Now
        });

        ContaCorrenteServico.Get().Lista.Add(new ContaCorrente(){
            IdCliente = IdCliente,
            Valor = 50,
            Data = DateTime.Now
        });
        
        // Processamento dados (Act)
        var extrato = ContaCorrenteServico.Get().ExtratoCliente(IdCliente);            
        

        //validacao (Assert)
        Assert.AreEqual(2, extrato.Count);
        
    }

    [TestMethod]
    public void TestandoRetornoDoExtratoComQuantidadeAMais(){
        
        Console.WriteLine("========== [TestandoRetornoDoExtratoComQuantidadeAMais] ==========");
        // Preparacao (Arrange)
        var IdCliente = Guid.NewGuid().ToString();
        ContaCorrenteServico.Get().Lista.Add(new ContaCorrente(){
            IdCliente = IdCliente,
            Valor = 100.01,
            Data = DateTime.Now
        });

        ContaCorrenteServico.Get().Lista.Add(new ContaCorrente(){
            IdCliente = IdCliente,
            Valor = 50,
            Data = DateTime.Now
        });
        
        var idCliente2 = Guid.NewGuid().ToString();
        ContaCorrenteServico.Get().Lista.Add(new ContaCorrente(){
            IdCliente = idCliente2,
            Valor = 40,
            Data = DateTime.Now
        });

        // Processamento dados (Act)
        var extrato = ContaCorrenteServico.Get().ExtratoCliente(idCliente2);            
        

        //validacao (Assert)
        Assert.AreEqual(1, extrato.Count);
        Assert.AreEqual(3, ContaCorrenteServico.Get().Lista.Count);
        
    }
}

