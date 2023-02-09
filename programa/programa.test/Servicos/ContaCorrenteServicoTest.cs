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
    [TestMethod]
    public void TestandoUnicaInstanciaDoServico(){
        
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
        
        // Preparacao (Arrange)
        Assert.IsNotNull(ContaCorrenteServico.Get());
        Assert.IsNotNull(ContaCorrenteServico.Get().Lista);

        // Processamento dados (Act)
        ContaCorrenteServico.Get().Lista.Add(new ContaCorrente(){
            IdCliente = "2122222"
            });            
        

        //validacao (Assert)
        Assert.AreEqual(1, ContaCorrenteServico.Get().Lista.Count);
        
    }
}

