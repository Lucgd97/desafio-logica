
// mostre() // mostrar uma mensagem na tela
// leia() // ler algo que o usuario digita
//csharp é dinamico (var), forte tipagem,
//data type c# = ver tipos primitivos da linguagem
// ? = nullabel
// sempre quesitonar o problema e pedir exemplo
// vc identificar string(classe ou primitivo) e tals é mais rapido para compilar ao inves de utilizar "var" pq espera a respota para identificar a varaivel 

Console.WriteLine("========================================="); // mostre
Console.WriteLine("=== Bem vindo ai meu primeiro sistema ==="); // mostre
Console.WriteLine("========================================="); // mostre

Console.WriteLine("Digite algo:"); // mostre()
var informacao = Console.ReadLine(); // leia() // vem acompanhado em armazenar(variavel) "setar algo"

Console.WriteLine($"""
    O valor que você digitou foi: {informacao}
    """);

Console.WriteLine("=== [Finalizando Sistema] ===");