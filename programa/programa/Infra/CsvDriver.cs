using System.ComponentModel;
using System.Text.Json;
using Programa.Infra.Interfaces;

public class CsvDriver<T> : IPersistencia<T>
{
    public CsvDriver(string localGravacao)
    {
        this.localGravacao = localGravacao;
    }

    private string localGravacao = "";

    
    public string GetLocalGravacao()
    {
        return this.localGravacao;
    }

    public async Task<T> BuscarPorId(string id)
    {
        throw new NotImplementedException();
    }

    public async Task Excluir(T objeto)
    {
        throw new NotImplementedException();
    }

    public async Task Salvar(T objeto)
    {
        var linhasDoCsv = new List<string>();
        var props = typeof(T).GetProperties();
        var header = string.Join(";", props.ToList().Select(x => x.Name));
        linhasDoCsv.Add(header);

        
        var lista = new List<T>();
        lista.Add(objeto);

        var valueLines = lista.Select(row => string.Join(";", header.Split(';').Select(a => row.GetType()?.GetProperty(a)?.GetValue(row, null))));
        linhasDoCsv.AddRange(valueLines);
        
        var csvString = string.Empty;
        foreach(var linha in linhasDoCsv)
        {
            csvString += linha + "\n";
        }

        var nome = objeto?.GetType().Name.ToLower();
        await File.WriteAllTextAsync($"{this.GetLocalGravacao()}/{nome}s.csv", csvString);
    }

    public async Task<List<T>> Todos()
    {
        throw new NotImplementedException();
    }

    Task IPersistencia<T>.ExcluirTudo()
    {
        throw new NotImplementedException();
    }
}