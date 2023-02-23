using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Programa.Models;
using Programa.Servicos;

namespace Programa.Test.Models;

[TestClass]
public class ClienteServicoTest
{
    [TestMethod]
    public void TestandoUnicaInstanciaDoServico(){
        
        // testar get (public or private)
        Assert.IsNotNull(ClienteServico.Get());
        Assert.IsNotNull(ClienteServico.Get().Lista);

        // test de lista
        ClienteServico.Get().Lista.Add(new Cliente(){
            Id = "23421",
            Nome = "teste"
        });            
        
        Assert.AreEqual(1, ClienteServico.Get().Lista.Count);
        
    }
}
