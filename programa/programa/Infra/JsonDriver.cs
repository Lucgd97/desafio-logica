using System.Text.Json;
using Programa.Infra.Interfaces;

public class JsonDriver : IPersistencia
{
    public JsonDriver(string localGravacao)
    {
        this.localGravacao = localGravacao;
    }

    private string localGravacao = "";

    
    public string GetLocalGravacao()
    {
        return this.localGravacao;
    }
    public async Task Alterar(string Id, object objeto)
    {
        throw new NotImplementedException();
    }

    public async Task<List<object>> BuscarPorId(string Id)
    {
        throw new NotImplementedException();
    }

    public async Task Excluir(object objeto)
    {
        throw new NotImplementedException();
    }

    public async Task Salvar(object objeto)
    {
        string jsonString = JsonSerializer.Serialize(objeto);
        
        var nome = objeto.GetType().Name.ToLower();
        await File.WriteAllTextAsync($"{this.GetLocalGravacao()}/{nome}s.json", jsonString);
    }

    public async Task<List<object>> Todos()
    {
        throw new NotImplementedException();
    }
}