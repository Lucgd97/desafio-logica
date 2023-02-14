using System.ComponentModel;
using System.Text.Json;
using Programa.Infra.Interfaces;

public class CsvDriver : IPersistencia
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
        var linhasDoCsv = new List<string>();
        var props = TypeDescriptor.GetProperties(objeto).OfType<PropertyDescriptor>();
        var header = string.Join(";", props.ToList().Select(x => x.Name));
        linhasDoCsv.Add(header);

        var lista = new List<object>();
        lista.Add(objeto);

        var valueLines = lista.Select(row => string.Join(";", header.Split(';').Select(a => row.GetType()?.GetProperty(a)?.GetValue(row, null))));
        linhasDoCsv.AddRange(valueLines);
        
        var csvString = string.Empty;
        foreach(var linha in linhasDoCsv)
        {
            csvString += linha + "\n";
        }

        var nome = objeto.GetType().Name.ToLower();
        await File.WriteAllTextAsync($"{this.GetLocalGravacao()}/{nome}s.csv", csvString);
    }

    public async Task<List<object>> Todos()
    {
        throw new NotImplementedException();
    }
}