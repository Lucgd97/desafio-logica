namespace Programa.Infra.Interfaces;

public interface IPersistencia
{
    Task Salvar(object objeto);
    void Excluir(object objeto);
    void Alterar(string Id, object objeto);
    List<Object> Todos();
    List<Object> BuscarPorId(string Id);

    string GetLocalGravacao();
}