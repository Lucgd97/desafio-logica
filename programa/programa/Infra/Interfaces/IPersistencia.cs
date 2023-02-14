namespace Programa.Infra.Interfaces;

public interface IPersistencia
{
    Task Salvar(object objeto);
    Task Excluir(object objeto);
    Task Alterar(string Id, object objeto);
    Task<List<Object>> Todos();
    Task<List<Object>> BuscarPorId(string Id);

    string GetLocalGravacao();
}