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
    public void TestandoInjecaoDeDependencia(){
                
        // testar get (public or private)
        var clienteServicoJson = new ClienteServico(new JsonDriver<Cliente>("bla"));
        Assert.IsNotNull(clienteServicoJson);
        Assert.IsNotNull(clienteServicoJson.Persistencia);

        var clienteServicoCsv = new ClienteServico(new CsvDriver<Cliente>("bla"));
        Assert.IsNotNull(clienteServicoCsv);
        Assert.IsNotNull(clienteServicoCsv.Persistencia);
        
    }
}
