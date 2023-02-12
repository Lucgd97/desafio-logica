
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Programa.Models;

namespace Programa.Infra;

[TestClass]
public class JsonDriverTest
{
    [TestMethod]
    public async Task TestandoPropriedadesDaClasse()
    {
        var caminhoArquivoTest = Environment.GetEnvironmentVariable("LOCAL_GRAVACAO_TEST_DESAFIO_DOTNET7");
        var jsonDriver = new JsonDriver(caminhoArquivoTest ?? "/tmp");

        var cliente = new Cliente()
        {
            Id = Guid.NewGuid().ToString(),
            Nome = "Danilo",
            Email = "danilo@teste.com",
            Telefone = "(11)12345-1234"
        };

        await jsonDriver.Salvar(cliente);

        var existe = File.Exists(caminhoArquivoTest + "/clientes.json");
    }
}