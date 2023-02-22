namespace Programa.Infra.Interfaces;

public interface IPersistencia<T>
{
    Task Salvar(T objeto);
    Task Excluir(T objeto);
    Task<List<T>> Todos();
    Task<T> BuscarPorId(string id);

    string GetLocalGravacao();
}