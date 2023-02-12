namespace Programa.Infra.Interfaces;

public interface IPersistencia
{
    Task Salvar(Object objeto);
    void Excluir(Object objeto);
    void Alterar(string Id, Object objeto);
    List<Object> Todos();
    List<Object> BuscarPorId(string Id);

    string GetLocalGravacao();
}