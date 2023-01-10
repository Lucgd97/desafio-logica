
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

Console.WriteLine("=== Tuabada V(2.0) ===");

Console.Write("Olá, digite seu nome: ");
var nome = Console.ReadLine();

Console.WriteLine($"Olá {nome}, digite o multiplicador:");
double multiplicador = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"Olá {nome}, digite a quantidade multiplicada:");
double multiplicacao = Convert.ToInt16(Console.ReadLine());

for (int i = 1; i <= multiplicacao; i++)
{
    Console.WriteLine($"{multiplicador} X {i} = {multiplicador * i}");
}