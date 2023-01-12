//while (true)
//{
//    Console.Clear();

//    Console.WriteLine("""
//    ================[ Seja Bem vindo a Empresa Lina V(1.0) ]=================
//    O que você deseja fazer ?
//    1 - Cadastrar o Cliente
//    2 - Ver conta conrrente
//    3 - Fazer Crebito em conta
//    4 - Fazer Dedito em conta
//    5 - Sair do Sistema
//    """);

//    var opcao = Console.ReadLine()?.Trim();
//    Console.Clear();

//    bool sair = false;


//    switch (opcao)
//    {
//        case "1":

//            Console.Write("Olá, digite seu nome: ");
//            var nome = Console.ReadLine();



//            break;
//        case "2":
//            Console.WriteLine($"Olá, digite o valor que irá depositar em R$:");
//            double saldo = Convert.ToDouble(Console.ReadLine());


//            Console.WriteLine("======== Saldo inicial ========");
//            Console.WriteLine($"saldo depositado em r$: {saldo} reais.");

//            Console.Clear();
//            break;

//            case "3":
//            Console.WriteLine($"""
//                Deseja realizar um Crédito?
//                Digite: S para Sim / N para Não
//                """);

//            Console.Clear();

//            break;
//            case "4":
//            Console.WriteLine($"""
//                Deseja realizar um Dédito?
//                Digite: S para Sim / N para Não
//                """);

//            break;
//        case "5":
//            sair = true;
//            break;
//        default:
//            Console.WriteLine("Opção inválida");
//            break;
//    }

//    if (sair) break;

//    Thread.Sleep(4000);
//}

//using System;

//while (true)
//{
//    Console.Clear();

//    Console.WriteLine("""
//    ================[ Seja Bem vindo a Empresa Lina V(2.0) ]=================
//    O que você deseja fazer ?
//    1 - Cadastrar o Cliente
//    2 - Ver conta conrrente
//    3 - Fazer Crebito em conta
//    4 - Fazer Dedito em conta
//    5 - Sair do Sistema
//    """);

//    var opcao = Console.ReadLine()?.Trim();
//    Console.Clear();
//    bool sair = false;


//    switch (opcao)
//    {
//        case "1":
//            var id = Guid.NewGuid();
//            Console.WriteLine("O Guid é " + id);

//            Console.Write("Olá Cliente, digite seu nome: \n");
//            var nome = Console.ReadLine();

//            Console.Write($"Olá {nome}, digite seu telefone: Ex (00) 00000 0000 \n");
//            var telefone = Console.ReadLine();

//            Console.Write("Digite seu email: \n");
//            var email = Console.ReadLine();

//            Console.WriteLine("==== Bem vindo a Empresa Lina====");
//            Console.WriteLine(nome);
//            Console.WriteLine(telefone);
//            Console.WriteLine(email);
//            Console.WriteLine(id);

//            break;
//        case "2":
//          //  Console.WriteLine($"Olá, digite o valor que irá depositar em R$:");
//          //  double saldo = Convert.ToDouble(Console.ReadLine());


//           // Console.WriteLine("======== Saldo inicial ========");
//           // Console.WriteLine($"saldo depositado em r$: {saldo} reais.");

//            //Console.Clear();
//            break;

//        case "3":
//         //   Console.WriteLine($"""
//            //    Deseja realizar um Crédito?
//           //     Digite: S para Sim / N para Não
//           //     """);

//            Console.Clear();

//            break;
//        case "4":
//           // Console.WriteLine($"""
//           //     Deseja realizar um Dédito?
//           //     Digite: S para Sim / N para Não
//           //     """);

//            break;
//        case "5":
//            sair = true;
//            break;
//        default:
//            Console.WriteLine("Opção inválida");
//            break;
//    }

//    if (sair) break;

//    Thread.Sleep(4000);
//}

using System;

List<string[]> list = new List<string[]>();

while (true)
{
    Console.Clear();

    Console.WriteLine("""
    ================[ Seja Bem vindo a Empresa Lina V(3.0) ]=================
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
            Console.Clear();

            var id = Guid.NewGuid();
            
                Console.Write("Olá Cliente, digite seu nome: \n");
                var nome = Console.ReadLine();

                Console.Write($"Olá {nome}, digite seu telefone: Ex (00) 00000 0000 \n");
                var telefone = Console.ReadLine();

                Console.Write("Digite seu email: \n");
                var email = Console.ReadLine();

            string[] cliente = { };

            cliente.Append(id.ToString());
            cliente.Append(nome);
            cliente.Append(email);
            cliente.Append(telefone);

                Console.WriteLine("\n==== Bem vindo a Empresa Lina ====");
                Console.WriteLine(nome);
                Console.WriteLine(telefone);
                Console.WriteLine(email);
                Console.WriteLine(id);

            break;
        case "2":
            //  Console.WriteLine($"Olá, digite o valor que irá depositar em R$:");
            //  double saldo = Convert.ToDouble(Console.ReadLine());


            // Console.WriteLine("======== Saldo inicial ========");
            // Console.WriteLine($"saldo depositado em r$: {saldo} reais.");

            //Console.Clear();
            break;

        case "3":
            //   Console.WriteLine($"""
            //    Deseja realizar um Crédito?
            //     Digite: S para Sim / N para Não
            //     """);

            Console.Clear();

            break;
        case "4":
            // Console.WriteLine($"""
            //     Deseja realizar um Dédito?
            //     Digite: S para Sim / N para Não
            //     """);

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