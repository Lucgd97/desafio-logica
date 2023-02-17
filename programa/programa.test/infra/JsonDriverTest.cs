
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Programa.Models;

namespace Programa.Infra;

[TestClass]
public class JsonDriverTest
{

    public JsonDriverTest()
    {
        var caminho = Environment.GetEnvironmentVariable("LOCAL_GRAVACAO_TEST_DESAFIO_DOTNET7") ?? "/tmp";
        this.caminhoArquivoTest = caminho;
    }

    private string caminhoArquivoTest;
    
    [TestMethod]
    public async Task TestandoDriverJsonParaClientes()
    {   
        
        var jsonDriver = new JsonDriver<Cliente>(this.caminhoArquivoTest);

        var cliente = new Cliente()
        {
            Id = Guid.NewGuid().ToString(),
            Nome = "Danilo",
            Email = "danilo@teste.com",
            Telefone = "(11)12345-1234"
        };

        await jsonDriver.Salvar(cliente);

        var existe = File.Exists(this.caminhoArquivoTest + "/clientes.json");
    }

    [TestMethod]
    public async Task TestandoDriverJsonParaContaCorrente()
    {  
        var jsonDriver = new JsonDriver<ContaCorrente>(this.caminhoArquivoTest);

        var contaCorrente = new ContaCorrente()
        {
            IdCliente = Guid.NewGuid().ToString(),
            Valor = 200,
            Data = DateTime.Now
        };

        await jsonDriver.Salvar(contaCorrente);

        var existe = File.Exists(this.caminhoArquivoTest + "/contascorrentes.json");
    }

    [TestMethod]
    public async Task TestandoBuscaDeTodasAsEntidades()
    {      
        var jsonDriver = new JsonDriver<ContaCorrente>(this.caminhoArquivoTest);
             
        var contaCorrente = new ContaCorrente()
        {
            IdCliente = Guid.NewGuid().ToString(),
            Valor = 200,
            Data = DateTime.Now
        };

        await jsonDriver.Salvar(contaCorrente);

        var todos = await jsonDriver.Todos();

        Assert.IsTrue(todos.Count > 0);
    }

    [TestMethod]
    public async Task TestandoAlterecaoDeEntidade()
    {      
        var jsonDriver = new JsonDriver<Cliente>(this.caminhoArquivoTest);
             
        var cliente = new Cliente(){
            Id =Guid.NewGuid().ToString(),
            Nome = "Danilo",
            Email = "danilo@teste.com",
            Telefone = "(16)12345-1234"
        };

        

        cliente.Nome = "Danilo Santos";

        await jsonDriver.Salvar(cliente);

        var clienteDb = await jsonDriver.BuscarPorId(cliente.Id);

        Assert.AreEqual("Danilo Santos", clienteDb.Nome);
    }
}