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


Console.WriteLine("=== PayBank V(3.0) ===");

Console.Write("Olá, digite seu nome: ");
var nome = Console.ReadLine();

Console.WriteLine($"Olá {nome}, digite o valor que irá depositar em R$:");
double saldo = Convert.ToDouble(Console.ReadLine());

var taxa = (saldo / 100) * 0.05;
double valorComTaxa = saldo - taxa;

Console.WriteLine("======== Saldo inicial ========");
Console.WriteLine($"saldo depositado em r$: {valorComTaxa} reais.");

Console.WriteLine($"""
    Deseja realizar um saque?
    Digite: S para Sim / N para Não
    """);

string escolha = Console.ReadLine();

if (escolha == "s")
{
    Console.WriteLine("Qual valor desaja sacar?");
    var saque = Convert.ToDouble((Console.ReadLine()));

    if (saque <= valorComTaxa)
    {
        valorComTaxa -= saque;
        Console.WriteLine($"Saque realizado com sucesso, saldo atual R${valorComTaxa}");
    }
    else
    {
        Console.WriteLine($"Desculpe valor superior ao saldo disponivel de R${valorComTaxa}");
    }
}
else
{
    Console.WriteLine("Obrigado por utilizar os serviços do PayBank");
}

