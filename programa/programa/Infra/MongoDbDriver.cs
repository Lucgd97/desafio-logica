using System.ComponentModel;
using System.Text.Json;
using MongoDB.Driver;
using Programa.Infra.Interfaces;
using MongoDB.Driver.Linq;

namespace Programa.Infra;

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
        return await this.mongoCollection().AsQueryable().Where(p => ((ICollectionMongoDb)p).Id == id).FirstAsync();
    }

    public async Task Excluir(T objeto)
    {
        await this.mongoCollection().DeleteOneAsync(p => ((ICollectionMongoDb)p).Id == ((ICollectionMongoDb)objeto).Id);
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
        foreach(var obj in await Todos())
        {
            if(obj == null) continue;
            var objContrato = (ICollectionMongoDb)obj;
            await this.mongoCollection().DeleteOneAsync(p => ((ICollectionMongoDb)p).Id == objContrato.Id); 
        }
    }
}
