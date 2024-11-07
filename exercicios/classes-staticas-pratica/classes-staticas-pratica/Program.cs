using System;

namespace classes_staticas_pratica
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Soma = " + Calculadora.Somar(8, 2));
            Console.WriteLine("Subtração =" + Calculadora.Subtrair(8, 2));

        }
    }
}