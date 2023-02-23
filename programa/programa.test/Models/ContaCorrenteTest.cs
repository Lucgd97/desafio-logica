using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Programa.Models;

namespace Programa.Test.Models;

[TestClass]
public class ContaCorrenteTest
{
    [TestMethod]
    public void TestandoPropriedadesDaClasse(){
        
        var contaCorrenteTest = new ContaCorrente() {IdCliente = "23432123"};
        // testar set (public or private)        
        contaCorrenteTest.Valor = 1;
        contaCorrenteTest.Data = DateTime.Now;
        
        // testar get (public or private)
        Assert.AreEqual("23432123", contaCorrenteTest.IdCliente);
        Assert.AreEqual(1, contaCorrenteTest.Valor);
        Assert.IsNotNull(contaCorrenteTest.Data);
        
    }
}