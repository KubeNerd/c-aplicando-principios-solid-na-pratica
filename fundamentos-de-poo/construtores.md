### Construtores em C#

```csharp
using System;

enum Genero {
    Masculino,
    Feminino,
    None
};

class Pessoa 
{
    public string Nome;
    public int Idade;
    public Genero GeneroPessoa;
    
    public Pessoa()
    {
        
    }

    public Pessoa(string nome, int idade, Genero genero)
    {
        Nome = nome;
        Idade = idade;
        GeneroPessoa = genero;
    }


    public void Identificar()
    {
      Console.WriteLine($"Olá, sou o {Nome} tenho {Idade} e sou do sexo {GeneroPessoa}.");
    }
}


public class Program
{

    public static void Main(string[] args)
    {

        Pessoa pessoa = new Pessoa();
        
        pessoa.Nome = "João";
        pessoa.Idade = 30;
        pessoa.GeneroPessoa = Genero.Masculino;

        Console.WriteLine("Nome: " + pessoa.Nome);
        Console.WriteLine("Idade: " + pessoa.Idade);
        Console.WriteLine("Gênero: " + pessoa.GeneroPessoa);
    }
}

```
