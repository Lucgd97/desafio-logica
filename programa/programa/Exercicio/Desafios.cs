﻿
        // Ex 1
        //Minha resolução desafio 1

        //Console.WriteLine("=== Bem vindo ao sistema de Cadastro de nome e Sobrenome V(1.0) ==="); 
        //Console.WriteLine("========================================="); 

        //Console.WriteLine("Digite 3 Nomes:"); 

        //var nome1 = Console.ReadLine();
        //var nome2 = Console.ReadLine();
        //var nome3 = Console.ReadLine();

        //Console.WriteLine($"""
        //    O valor que você digitou foi: {nome1}, {nome2}, {nome3}.
        //    """);

        //Console.WriteLine("Digite 3 Sobrenomes:");
        //var Sobrenome1 = Console.ReadLine();
        //var Sobrenome2 = Console.ReadLine();
        //var Sobrenome3 = Console.ReadLine();

        //Console.WriteLine($"""
        //    O valor que você digitou foi: {nome1 + Sobrenome1}, {nome2 + Sobrenome2}, {nome3 + Sobrenome3}.
        //    """);

        //Console.WriteLine("=== [Finalizando Sistema] ===");


        // Correção e melhorias da aula ao vivo
        //Console.WriteLine("=== Bem vindo ao sistema de Cadastro de Nome e Sobrenome V(2.0) ===");


        //Console.WriteLine("Digite o primeiro nome:");
        //var nome1 = Console.ReadLine();
        //Console.WriteLine("Digite o segundo nome:");
        //var nome2 = Console.ReadLine();
        //Console.WriteLine("Digite o terceiro nome:");
        //var nome3 = Console.ReadLine();


        //Console.WriteLine("Digite o primeiro sobrenome");
        //var Sobrenome1 = Console.ReadLine();
        //Console.WriteLine("Digite o segundo sobrenome");
        //var Sobrenome2 = Console.ReadLine();
        //Console.WriteLine("Digite o terceiro sobrenome");
        //var Sobrenome3 = Console.ReadLine();

        //Console.WriteLine($"Nome 1: {nome1} {Sobrenome1}");
        //Console.WriteLine($"Nome 2: {nome2} {Sobrenome2}");
        //Console.WriteLine($"Nome 3: {nome3} {Sobrenome3}");

        //Console.WriteLine("=== [Finalizando Sistema] ===");


        // ex 2
        /*
     Ex 2
     qtd comb
     preço litro
     mostrar esotque 
     valor de abastecimento
     qtd de litro abastecido
     valor por litro

     Melhorias 2.0
     pedir o nome X
     camelCase
     usabilidade do programa faltou
    */

        //Console.WriteLine("=== Sistema Posto de combustivel V(1.0) ===");

        //Console.WriteLine("Digite o estoque de litros de combustivel:");
        //double estoque = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Digite o preço do litro do combustivel:");
        //double litro = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine($"Estoque em litros disponível: {estoque}");

        //Console.WriteLine("Digite o valor que irá abastecer em R$:");
        //double valor = Convert.ToDouble(Console.ReadLine());

        //var precolitro = valor / litro;
        //Console.WriteLine($"Você abasteceu: {precolitro} litros");

        //estoque -= precolitro;
        //Console.WriteLine($"Estoque disónivel para abastecimento: {estoque}");

        // Versão melhorada da aula ao vivo
        //Console.WriteLine("=== Sistema Posto de combustivel V(2.0) ===");

        //Console.WriteLine("Digite o estoque de litros de combustivel:");
        //double estoque = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Digite o preço do litro do combustivel:");
        //double litro = Convert.ToDouble(Console.ReadLine());

        //var estoqueReais = estoque * litro;

        //Console.WriteLine("======== Estoque Inicial ========");
        //Console.WriteLine($"Estoque: {estoque} litros.");
        //Console.WriteLine($"Estoque em R$: {estoqueReais} reais.");
        //Console.WriteLine("===============================\n");

        //Console.Write("Olá, digite seu nome: ");
        //var nome = Console.ReadLine();

        //Console.WriteLine($"Olá {nome}, digite o valor que irá abastecer em R$:");
        //double valor = Convert.ToDouble(Console.ReadLine());

        //var precolitro = valor / litro;
        //Console.WriteLine($"Você abasteceu: {precolitro} litros\n");

        //estoque -= precolitro;
        //var estoqueReais2 = estoque * litro;

        //Console.WriteLine("======== Estoque Final ========");
        //Console.WriteLine($"Estoque: {estoque} litros.");
        //Console.WriteLine($"Estoque em R$: {estoqueReais2} reais\n");
        //Console.WriteLine("======== Finalizando... ========");

        //Ex 3
        /*
        saldo
        descontar saldo 0,05%

       deseja sacar 
       se sim qual valor
       se sim for maior que saldo pedir para digitar novamente
       se n tchau

        */

        //Console.WriteLine("=== Paybank V(1.0) ===");

        //Console.Write("Olá, digite seu nome: ");
        //var nome = Console.ReadLine();

        //Console.WriteLine($"Olá {nome}, digite o valor que irá depositar em R$:");
        //double saldo = Convert.ToDouble(Console.ReadLine());

        //var taxa = (saldo/100) * 0.05;
        //double valorComTaxa = saldo - taxa;

        //Console.WriteLine("======== Conta Inicial ========");
        //Console.WriteLine($"Saldo depositado em R$: {saldo} reais.");
        //Console.WriteLine($"Saldo com cobraçanda da taxa: {valorComTaxa} reais.");
        //Console.WriteLine("=============================\n");

        //Console.WriteLine($"Olá {nome}, dejesa realizar um saque? Responder S / N");
        //string? saque = Console.ReadLine();


        //Console.WriteLine("=== PayBank V(2.0) ===");

        //Console.Write("Olá, digite seu nome: ");
        //var nome = Console.ReadLine();

        //Console.WriteLine($"Olá {nome}, digite o valor que irá depositar em R$:");
        //double saldo = Convert.ToDouble(Console.ReadLine());

        //var taxa = (saldo / 100) * 0.05;
        //double valorComTaxa = saldo - taxa;

        //Console.WriteLine("======== conta inicial ========");
        //Console.WriteLine($"saldo depositado em r$: {valorComTaxa} reais.");

        //Console.WriteLine($"""
        //    Deseja realizar um saque?
        //    Digite 1 para Sim / 2 para Não
        //    """);
        //var escolha = Convert.ToInt16((Console.ReadLine()));

        //if (escolha == 1)
        //{
        //    Console.WriteLine("Qual valor desaja sacar?");
        //    var saque = Convert.ToDouble((Console.ReadLine()));

        //    if (saque <= valorComTaxa)
        //    {
        //        valorComTaxa -= saque;
        //        Console.WriteLine($"Saque realizado com sucesso, saldo atual R${valorComTaxa}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Desculpe valor superior ao saldo disponivel de R${valorComTaxa}");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Obrigado por utilizar os serviços do PayBank");
        //}


        //Console.WriteLine("=== PayBank V(3.0) ===");

        //Console.Write("Olá, digite seu nome: ");
        //var nome = Console.ReadLine();

        //Console.WriteLine($"Olá {nome}, digite o valor que irá depositar em R$:");
        //double saldo = Convert.ToDouble(Console.ReadLine());

        //var taxa = (saldo / 100) * 0.05;
        //double valorComTaxa = saldo - taxa;

        //Console.WriteLine("======== Saldo inicial ========");
        //Console.WriteLine($"saldo depositado em r$: {valorComTaxa} reais.");

        //Console.WriteLine($"""
        //    Deseja realizar um saque?
        //    Digite: S para Sim / N para Não
        //    """);

        //string escolha = Console.ReadLine();

        //if (escolha == "s")
        //{
        //    Console.WriteLine("Qual valor desaja sacar?");
        //    var saque = Convert.ToDouble((Console.ReadLine()));

        //    if (saque <= valorComTaxa)
        //    {
        //        valorComTaxa -= saque;
        //        Console.WriteLine($"Saque realizado com sucesso, saldo atual R${valorComTaxa}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Desculpe valor superior ao saldo disponivel de R${valorComTaxa}");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Obrigado por utilizar os serviços do PayBank");
        //}

        // ex 4

        //Console.WriteLine("Veiculo saindo ...");
        //Thread.Sleep(2000);
        //for (var km = 0; km <= 1000; km++)
        //{
        //    Console.WriteLine($"Passando pelo km {km} ...");
        //    Thread.Sleep(10);
        //}

        //ex 5
        //Console.WriteLine("=== Tuabada V(1.0) ===");

        //Console.Write("Olá, digite seu nome: ");
        //var nome = Console.ReadLine();

        //Console.WriteLine($"Olá {nome}, digite o multiplicador:");
        //double multiplicador = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine($"Olá {nome}, digite a quantidade mult´iplicada:");
        //double multiplicacao = Convert.ToDouble(Console.ReadLine());

        //for (int multiplicacao = 0; multiplicacao <= multiplicador; multiplicacao++)
        //{
        //    Console.WriteLine(multiplicador + " * " + multiplicacao + " = " + multiplicador * multiplicador);
        //}

        //Console.WriteLine("=== Tuabada V(2.0) ===");

        //Console.Write("Olá, digite seu nome: ");
        //var nome = Console.ReadLine();

        //Console.WriteLine($"Olá {nome}, digite o multiplicador:");
        //double multiplicador = Convert.ToInt16(Console.ReadLine());

        //Console.WriteLine($"Olá {nome}, digite a quantidade multiplicada:");
        //double multiplicacao = Convert.ToInt16(Console.ReadLine());

        //for (int i = 1; i <= multiplicacao; i++)
        //{
        //    Console.WriteLine($"{multiplicador} X {i} = {multiplicador * i}");
        //}

        // ex 6 minha versao
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
 