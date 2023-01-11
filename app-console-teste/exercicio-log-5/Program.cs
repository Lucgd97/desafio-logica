while (true)
{
    Console.Clear();

    Console.WriteLine("""
    ================[ Seja Bem vindo a Empresa Lina V(1.0) ]=================
    O que você deseja fazer ?
    1 - Cadastrar o Cliente
    2 - Ver conta conrrente
    3 - Fazer Crebito em conta
    4 - Fazer Dedito em conta
    5 - Sair do Sistema
    """);

    var opcao = Console.ReadLine()?.Trim();
    Console.Clear();

    bool sair = false;
   

    switch (opcao)
    {
        case "1":

            Console.Write("Olá, digite seu nome: ");
            var nome = Console.ReadLine();

            

            break;
        case "2":
            Console.WriteLine($"Olá, digite o valor que irá depositar em R$:");
            double saldo = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("======== Saldo inicial ========");
            Console.WriteLine($"saldo depositado em r$: {saldo} reais.");

            Console.Clear();
            break;

            case "3":
            Console.WriteLine($"""
                Deseja realizar um Crédito?
                Digite: S para Sim / N para Não
                """);

            Console.Clear();

            break;
            case "4":
            Console.WriteLine($"""
                Deseja realizar um Dédito?
                Digite: S para Sim / N para Não
                """);

            break;
        case "5":
            sair = true;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    if (sair) break;

    Thread.Sleep(4000);
}
