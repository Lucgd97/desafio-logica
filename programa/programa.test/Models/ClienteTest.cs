using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Programa.Models;

namespace Programa.Test.Models;

[TestClass]
public class ClienteTest
{
    [TestMethod]
    public void TestandoPropriedadesDaClasse(){
        
        var cliente = new Cliente();
        // testar set (public or private)
        cliente.Id = "23432123";
        cliente.Nome = "Marcela";
        cliente.Email = "ma@teste.com";
        cliente.Telefone = "(11)12345-1234";

        // testar get (public or private)
        Assert.AreEqual("23432123", cliente.Id);
        Assert.AreEqual("Marcela", cliente.Nome);
        Assert.AreEqual("ma@teste.com", cliente.Email);
        Assert.AreEqual("(11)12345-1234", cliente.Telefone);
    }
}