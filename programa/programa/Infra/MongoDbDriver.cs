using System.ComponentModel;
using System.Text.Json;
using MongoDB.Driver;
using Programa.Infra.Interfaces;

public class MongoDbDriver<T> : IPersistencia<T>
{
    private IMongoDatabase mongoDatabase;
    public MongoDbDriver(string localGravacao)
    {
        this.localGravacao = localGravacao;
        var cnn = this.localGravacao.Split('#');
        this.mongoDatabase = new MongoClient(cnn[0]).GetDatabase(cnn[1]);
    }

    private IMongoCollection<T> mongoCollection()
    {
        return this.mongoDatabase.GetCollection<T>($"{typeof(T).Name.ToLower()}s");
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
        throw new NotImplementedException();
    }

    public async Task<List<T>> Todos()
    {
        return await this.mongoCollection().AsQueryable().ToListAsync();
    }

    public async Task ExcluirTudo()
    {
        throw new NotImplementedException();
    }
}