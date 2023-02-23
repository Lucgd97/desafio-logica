
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Programa.Models;

namespace Programa.Infra;

[TestClass]
public class CsvDriverTest
{

    public CsvDriverTest()
    {
        var caminho = Environment.GetEnvironmentVariable("LOCAL_GRAVACAO_TEST_DESAFIO_DOTNET7") ?? "/tmp";
        this.caminhoArquivoTest = caminho; 
    }

    private string caminhoArquivoTest;

    [TestMethod]
    public async Task TestandoDriverJsonParaClientes()
    {   
        
        var csvDriver = new CsvDriver<Cliente>(this.caminhoArquivoTest);

        var cliente = new Cliente()
        {
            Id = Guid.NewGuid().ToString(),
            Nome = "Danilo",
            Email = "danilo@teste.com",
            Telefone = "(11)12345-1234"
        };

        await csvDriver.Salvar(cliente);

        var existe = File.Exists(this.caminhoArquivoTest + "/clientes.csv");
    }

    [TestMethod]
    public async Task TestandoDriverJsonParaContaCorrente()
    {        
        var csvDriver = new CsvDriver<ContaCorrente>(this.caminhoArquivoTest);

        var contaCorrente = new ContaCorrente()
        {
            Id = Guid.NewGuid().ToString(),
            IdCliente = Guid.NewGuid().ToString(),
            Valor = 200,
            Data = DateTime.Now
        };

        await csvDriver.Salvar(contaCorrente);

        var existe = File.Exists(this.caminhoArquivoTest + "/contascorrentes.csv");
    }
    
}