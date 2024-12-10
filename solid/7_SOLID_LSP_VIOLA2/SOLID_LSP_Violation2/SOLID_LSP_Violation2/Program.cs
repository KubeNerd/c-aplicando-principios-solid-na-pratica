using SOLID_LSP_Violation2;

var numeros = new int[] { 5, 7, 9, 8, 1, 6, 4 };


CalculaSoma somaNumeros = new CalculaSoma(numeros);
Console.WriteLine($"\nA soma dos números é : {somaNumeros.Calcular()}");

CalculaSomaNumerosPares somaPares = new CalculaSomaNumerosPares(numeros);
Console.WriteLine($"\nSoma dos números pares: {somaPares.Calcular()}");

//Substituindo a instância da classe base
//por uma instância da classe derivada
CalculaSoma soma = new CalculaSomaNumerosPares(numeros);

Console.WriteLine($"\nSoma de todos os pares: {soma.Calcular()}");


Console.ReadKey();










