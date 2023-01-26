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

//using System;
//using System.ComponentModel;

//List<string[]> list = new List<string[]>();

//while (true)
//{
//    Console.Clear();

//    Console.WriteLine("""
//    ================[ Seja Bem vindo a Empresa Lina V(3.0) ]=================
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
//            Console.Clear();
//            cadastrarCliente();

//            break;
//        case "2":

//            Console.Clear();
//            cadastrarSaldo();

//            break;

//        case "3":

//            Console.Clear();
//            credito();

//            break;
//        case "4":
//            // Console.WriteLine($"""
//            //     Deseja realizar um Dédito?
//            //     Digite: S para Sim / N para Não
//            //     """);

//            break;
//        case "5":
//            sair = true;
//            break;
//        default:
//            Console.WriteLine("Opção inválida");
//            break;
//    }

//    void cadastrarCliente()
//    {
//        var id = Guid.NewGuid();

//        Console.Write("Olá Cliente, digite seu nome: \n");
//        var nome = Console.ReadLine();

//        Console.Write($"Olá {nome}, digite seu telefone: Ex (00) 00000 0000 \n");
//        var telefone = Console.ReadLine();

//        Console.Write("Digite seu email: \n");
//        var email = Console.ReadLine();


//        string[] cliente = new string[4];

//        cliente[0] = id.ToString();
//        cliente[1] = nome != null ? nome : "[Sem Nome]";
//        cliente[2] = telefone != null ? telefone : "[Sem Telefone ]";
//        cliente[3] = email != null ? email : "[Sem Email]";


//        mensagem($"""Cliente {id} - {nome} cadastrado com sucesso.""");
//    }

//    if (sair) break;

//    Thread.Sleep(4000);
//}

//void cadastrarSaldo()
//{
//    Console.WriteLine($"Olá, digite o valor que irá depositar em R$:");
//    double saldo = Convert.ToDouble(Console.ReadLine());

//    double[] deposito = new double[1];

//    deposito[0] = saldo;

//    Console.WriteLine($"Seu saldo é de R$: {saldo}");

//}


//void credito()
//{
//   foreach(double valorDeposito in saldo)
//    Console.WriteLine($"Seu valor em conta é de R$: {saldo}");
//}


//void mensagem(string msg)
//{
//    Console.Clear();
//    Console.WriteLine(msg);
//    Thread.Sleep(2000);
//}

List<dynamic> listaDeClientes = new List<dynamic>();
List<dynamic> contaCorrete = new List<dynamic>();

while (true)
{
    Console.Clear();

    Console.WriteLine("""
    =================[Seja bem-vindo à empresa Lina]=================
    O que você deseja fazer?
    1 - Cadastrar o cliente
    2 - Ver extrato cliente
    3 - Crédito em conta
    4 - Retirada
    5 - Sair do sistema
    """);

    var opcao = Console.ReadLine()?.Trim();
    Console.Clear();
    bool sair = false;

    switch (opcao)
    {
        case "1":
            Console.Clear();
            cadastrarCliente();
            break;
        case "2":
            Console.Clear();
            mostrarContaCorrente();
            break;
        case "3":
            Console.Clear();
            adicionarCreditoCliente();
            break;
        case "4":
            Console.Clear();
            fazendoDebitoCliente();
            break;
        case "5":
            sair = true;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    if (sair) break;
}

void mostrarContaCorrente()
{
    Console.Clear();

    if (listaDeClientes.Count == 0 || contaCorrete.Count == 0)
    {
        mensagem("Não existe clientes ou não existe movimentações em conta correte, cadastre o cliente e faça crédito em conta");
        return;
    }

    var cliente = capturaCliente();

    var contaCorrenteCliente = extratoCliente(cliente[0]);
    Console.Clear();
    Console.WriteLine("----------------------");
    foreach (var contaCorrente in contaCorrenteCliente)
    {
        Console.WriteLine("Data: " + contaCorrente[2]);
        Console.WriteLine("Valor: " + contaCorrente[1]);
        Console.WriteLine("----------------------");
    }

    Console.WriteLine($"""
    O valor total da conta do cliente {cliente[1]} é de:
    R$ {saldoCliente(cliente[0], contaCorrenteCliente)}
    """);


    Console.WriteLine("Digite enter para continuar");
    Console.ReadLine();
}

void listarClientesCadastrados()
{
    if (listaDeClientes.Count == 0)
    {
        menuCadastraClienteSeNaoExiste();
    }

    mostrarClientes(false, 0, "===============[ Selecione um cliente da lista ]===================");
}

void mostrarClientes(
    bool sleep = true,
    int timerSleep = 2000,
    string header = "===============[ Lista de clientes ]===================")
{
    Console.Clear();
    Console.WriteLine(header);

    foreach (var cliente in listaDeClientes)
    {
        Console.WriteLine("Id:" + cliente[0]);
        Console.WriteLine("Nome:" + cliente[1]);
        Console.WriteLine("Telefone:" + cliente[2]);
        Console.WriteLine("Email:" + cliente[3]);
        Console.WriteLine("----------------------------");

        if (sleep)
        {
            Thread.Sleep(timerSleep);
            Console.Clear();
        }
    }
}

void cadastrarCliente()
{
    var id = Guid.NewGuid().ToString();

    Console.WriteLine("Informe o nome do cliente:");
    var nomeCliente = Console.ReadLine();

    Console.WriteLine($"Informe o telefone do cliente {nomeCliente}: ");
    var telefone = Console.ReadLine();

    Console.WriteLine($"Informe o email do cliente {nomeCliente}: ");
    var email = Console.ReadLine();

    if (listaDeClientes.Count > 0)
    {
        var cli = listaDeClientes.Find(c => c.Telefone == telefone);
        if (cli != null)
        {
            mensagem($"Cliente já cadastrado com este telefone {telefone}, cadastre novamente");
            cadastrarCliente();
        }
    }

    listaDeClientes.Add(new
    {
        Id = id,
        Nome = nomeCliente ?? "[Sem Nome]",
        Telefone = telefone != null ? telefone : "[Sem Telefone]",
        Email = email ?? "[Sem Email]"
    });

    mensagem($""" {nomeCliente} cadastrado com sucesso. """);
}

void mensagem(string msg)
{
    Console.Clear();
    Console.WriteLine(msg);
    Thread.Sleep(1500);
}

void fazendoDebitoCliente()
{
    Console.Clear();
    var cliente = capturaCliente();
    Console.Clear();
    Console.WriteLine("Digite o valor de retirada:");
    double credito = Convert.ToDouble(Console.ReadLine());
    string[] creditoConta = new string[3];

    creditoConta[0] = cliente[0];
    creditoConta[1] = $"-{credito}";
    creditoConta[2] = DateTime.Now.ToString("dd/MM/yyyy HH:MM");

    contaCorrete.Add(creditoConta);

    var idCliente = cliente[0];
    mensagem($"""
    Retirada realizada com sucesso ...
    Saldo do cliente {cliente[1]} é de R$ {saldoCliente(idCliente)}
    """);
}


void adicionarCreditoCliente()
{
    Console.Clear();
    var cliente = capturaCliente();
    Console.Clear();
    Console.WriteLine("Digite o valor do crédito:");
    double credito = Convert.ToDouble(Console.ReadLine());
    string[] creditoConta = new string[3];

    creditoConta[0] = cliente[0];
    creditoConta[1] = credito.ToString();
    creditoConta[2] = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

    contaCorrete.Add(creditoConta);

    var idCliente = cliente[0];
    mensagem($"""
    Credito adicionado com sucesso ...
    Saldo do cliente {cliente[1]} é de R$ {saldoCliente(idCliente)}
    """);
}


List<string[]> extratoCliente(string idCliente)
{
    var contaCorreteCliente = contaCorrete.FindAll(cc => cc[0] == idCliente);
    if (contaCorreteCliente.Count == 0) return new List<string[]>();

    return contaCorreteCliente;
}

double saldoCliente(string idCliente, List<string[]>? contaCorreteCliente = null)
{
    if (contaCorreteCliente == null)
        contaCorreteCliente = extratoCliente(idCliente);

    return contaCorreteCliente.Sum(cc => Convert.ToDouble(cc[1]));
}

string[] capturaCliente()
{
    listarClientesCadastrados();
    Console.WriteLine("Digite o ID do cliente");
    var idCliente = Console.ReadLine()?.Trim();
    string[]? cliente = listaDeClientes.Find(c => c[0] == idCliente);

    if (cliente == null)
    {
        mensagem("Cliente não encontrado na lista, digite o ID corretamente da lista de clientes");
        Console.Clear();

        menuCadastraClienteSeNaoExiste();

        return capturaCliente();
    }

    return cliente;
}

void menuCadastraClienteSeNaoExiste()
{
    Console.WriteLine("""
        O que você deseja fazer ?
        1 - Cadastrar cliente
        2 - Voltar ao menu
        3 - Sair do programa
        """);

    var opcao = Console.ReadLine()?.Trim();

    switch (opcao)
    {
        case "1":
            cadastrarCliente();
            break;
        case "3":
            break;
        case "2":
            System.Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}