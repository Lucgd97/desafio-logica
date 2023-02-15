using System.Text.Json;
using Programa.Infra.Interfaces;

public class JsonDriver<T> : IPersistencia<T>
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
    public async Task Alterar(string Id, T objeto)
    {
        throw new NotImplementedException();
    }

    public async Task<List<T>> BuscarPorId(string Id)
    {
        throw new NotImplementedException();
    }

    public async Task Excluir(T objeto)
    {
        throw new NotImplementedException();
    }

    public async Task Salvar(T objeto)
    {
        var lista = await Todos();
        lista.Add(objeto);

        string jsonString = JsonSerializer.Serialize(lista);
        
        var nome = typeof(T).Name.ToLower();
        await File.WriteAllTextAsync($"{this.GetLocalGravacao()}/{nome}s.json", jsonString);
    }

    public async Task<List<T>> Todos()
    {
        var nome = typeof(T).Name.ToLower(); 

        var arquivo = $"{this.GetLocalGravacao()}/{nome}s.json";
        if(!File.Exists(arquivo)) return new List<T>();

        string jsonString = await File.ReadAllTextAsync(arquivo);       
        var lista = JsonSerializer.Deserialize<List<T>>(jsonString);
        return lista ?? new List<T>();       
    }
}