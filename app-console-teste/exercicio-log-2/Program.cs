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
Console.WriteLine("=== Sistema Posto de combustivel V(2.0) ===");

Console.WriteLine("Digite o estoque de litros de combustivel:");
double estoque = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o preço do litro do combustivel:");
double litro = Convert.ToDouble(Console.ReadLine());

var estoqueReais = estoque * litro;

Console.WriteLine("======== Estoque Inicial ========");
Console.WriteLine($"Estoque: {estoque} litros.");
Console.WriteLine($"Estoque em R$: {estoqueReais} reais.");
Console.WriteLine("===============================\n");

Console.Write("Olá, digite seu nome: ");
var nome = Console.ReadLine();

Console.WriteLine($"Olá {nome}, digite o valor que irá abastecer em R$:");
double valor = Convert.ToDouble(Console.ReadLine());

var precolitro = valor / litro;
Console.WriteLine($"Você abasteceu: {precolitro} litros\n");

estoque -= precolitro;
var estoqueReais2 = estoque * litro;

Console.WriteLine("======== Estoque Final ========");
Console.WriteLine($"Estoque: {estoque} litros.");
Console.WriteLine($"Estoque em R$: {estoqueReais2} reais\n");
Console.WriteLine("======== Finalizando... ========");
