1 - Defina oque é uma classe, e oque é um objeto.

Uma classe é uma strutura/Conjunto de dados. Com propriedades como métodos, construtores.

A classe é a base de um objeto. Sem classes não há objetos no csharp. Classe no geral, é como um gabarito de objto.


Defininod uma classe:
```csharp
    class Veiculo 
    {

    }
```


2 - Definição do conceito de abstração no POO

Um dos pilares de POO, especificamente, um dos 4 pilares.
  Abstração
  Polimofismo
  Herança
  Encapsulamento

Abstração, pra mim de certa forma é facilitar um processo. Eliminando visualmente, ou técnicamente distrações ou caminhos que poderiam não gerar valor. 

Reduzir a complixidade de algo, e não se esforçar tanto, seguindo boas praticas.

3 - Exemplo de abstração do mundo real

Uma receita de bolo, é um conjunto de instruções, e passos para fazer um bolo. 

Eu não preciso ser um confeiteiro, desde que eu siga estritamente passos. Desde os ingredientes, até os procedimentos de preparação da massa. Até assar de fato.


5 - Quando o construtor da classe é chamado ?

Quando é instanciado ? E passamos os parametros.


6 - Se criar 5 métodos de uma classe, quantas vezes o construtor será chamado ?

Todas as 5 vezes que instanciar a classe.

7 - Porque vpcê usa um construtor ?

O construtor é a parte mais importante de uma classe. Ele é o cara que, em um cenário de uma classe concreata, vai receber dados, e iniciar a lógica da classe. Após isso, os métodos auxiliares entram em ação. Por exemplo, nas libs de api, por exemplo do telegram, o construtor é o primeiro a receber um parametro, que é o token, após isso, podemos seguir com os demais passos.

8 - Criar uma classe para calcular 2 numeros inteiros usando o conceito de sobrecarga de métodos. Se nenhum valor for informado retorne "Nenhum valor fornecido".


```csharp

using System;

public class Program
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
            if (numero1 < 0 || numero2 < 0)
            {
                throw new ArgumentException("Nenhum valor informado.");
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
```

9- Crie uma classe para calcular a soma de até 4 números inteiros usando o conceito de
parâmetros opcionais.
```csharp
using System;

public class Program
{
    class Calcular
    {
        // Método para somar 2 números
        public int Soma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        // Sobrecarga do método para somar 3 números, com o terceiro número opcional
        public int Soma(int numero1, int numero2, int numero3 = 0)
        {
            return numero1 + numero2 + numero3;
        }

        // Sobrecarga do método para somar 4 números, com o terceiro e o quarto número opcionais
        public int Soma(int numero1, int numero2, int numero3 = 0, int numero4 = 0)
        {
            return numero1 + numero2 + numero3 + numero4;
        }
    }

    public static void Main(string[] args)
    {
        Calcular calcular = new Calcular();

        // Exemplo de soma com 2 números
        Console.WriteLine("Soma de 2 números: " + calcular.Soma(10, 20));

        // Exemplo de soma com 3 números
        Console.WriteLine("Soma de 3 números: " + calcular.Soma(10, 20, 30));

        // Exemplo de soma com 4 números
        Console.WriteLine("Soma de 4 números: " + calcular.Soma(10, 20, 30, 40));
    }
}


```


10- Qual o conceito de herança? Dê um exemplo
Herança é um conceito, que se esclarece pelo proprio nome. mas abstraindo o conceito, temos uma ou mais classes pai, que possuem métodos, propriedades,e objetos que podem ser herdadas pelas classes filhas. Se eu definir a classe veiculo, tudo oque for public, ou internal, será reaproveitado pelas classes filhas(o internal se limita ao assembly local.)