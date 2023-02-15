namespace Programa.Infra.Interfaces;

public interface IPersistencia<T>
{
    Task Salvar(T objeto);
    Task Excluir(T objeto);
    Task Alterar(string Id, T objeto);
    Task<List<T>> Todos();
    Task<List<T>> BuscarPorId(string Id);

    string GetLocalGravacao();
}