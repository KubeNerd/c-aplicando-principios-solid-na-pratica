
using System;

public class HelloWorld
{
    class Calcular
    {
        public int Numero1 {get; set;}
        public int Numero2 {get; set;}
        public Calcular()
        {
    
        }
        public Calcular(int numero1, int numero2)
        {
            if(numero1 == null || numero2 == null)
            {
                Console.WriteLine("Nenhum numero foi informado");
            }
            this.Numero1 = numero1;
            this.Numero2 = numero2;
            this.Numero1 = numero1;
            this.Numero2 = numero2;
        }
        
        public int soma(int numero1, int numero2)
        {
            return this.Numero1 + this.Numero2;
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o numero 1:");
        int InputNumero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o numero 2:");
        int InputNumero2 = int.Parse(Console.ReadLine());

        Calcular calcular = new Calcular
        {
            Numero1 = InputNumero1;
            Numero2 = InputNumero2;
        }
    }
}