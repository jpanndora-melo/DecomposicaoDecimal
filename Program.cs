Console.WriteLine("--- Decomposição Decimal ---\n");

Console.Write("Digite um numero inteiro positivo: ");
int numero = int.Parse(Console.ReadLine()!);
int unidade = numero % 10;
int dezena = (numero / 10) % 10;
int centena = (numero / 100) % 10;
int milhar = (numero / 1000) % 10;
Console.WriteLine($"\nUnidade: {unidade}");
Console.WriteLine($"Dezena: {dezena}");
Console.WriteLine($"Centena: {centena}");
Console.WriteLine($"Milhar: {milhar}");
Console.WriteLine("\n---------------------------");
