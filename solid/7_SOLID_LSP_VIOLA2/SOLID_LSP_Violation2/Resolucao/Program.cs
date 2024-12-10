
using Resolucao;

var numeros = new int[] { 5, 7, 9, 8, 1, 6, 4 };

Calculadora somaNumeros = new CalculaSoma(numeros);
Console.WriteLine($"\nSoma de todos os números: {somaNumeros.Calcular()}");

Calculadora somaPares =new CalculaSomaNumeroPares(numeros);
Console.WriteLine($"Soma dos números pares : {somaPares.Calcular()}");

Console.ReadKey();