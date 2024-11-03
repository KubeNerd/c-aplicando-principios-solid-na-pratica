# Programação Orientada a Objetos em C#

## Os prinípios básicos da POO

1 - Encapsulamento - Permite ocultar a implementação de uma classe do mundo externo.<br/>
2 - Herança - Permite herdar atribuitos e comportamentos da classe.<br/>
3 - Polimorfismo - Permite que um objeto se comporte de formas diferentes.<br/>
4 - Abstração - É o processo de identificação dos objetos e seus relacionamentos.<br/>

### A programação orientada a objetos tem váris vantagens sobre a programação procedural:

1 - Ela permite criar código mais rápido e fácil de executar.<br/>
2 - A POO fornece uma estrutura clara para os programas.<br/>
3 - A POO ajuda a manter o código enxuto e facilita a manutenção, modificação e depuração do código.<br/>
4 - A POO torna possível criar aplicativos reutilizáveis completos com menos código e menor tempo de desenvolvimento.<br/>


### Classes e Objetos em C#
Em csharp, tudo está associado com classes e objetos junto com seus comportamentos.<br/>

Uma classe é um modeço ou template para criar objetos e contém os atributos e comportamentos que definem os objetos.<br/>

Os objetos não existem sem a classe.<br/>

Classe Pessoa:
    Nome<br/>
    Idade<br/>
    Genero<br/>


#### Fields/ Attributes

```csharp
class Pessoa 
{
    string Nome;
    string Idate;
    string Genero;
}

```

#### Mebros da classe

Exemplo:
```csharp
class Pessoa 
{

    //Fields
    //Properties
    //Constructor
    //Methods
}

```

#### Exemplo de objetos com base em uma classe:

No geral, podemos entender que os objetos no Csharp, são instancia de classe. Por isso, sem classe não existe objeto.<br/>

```csharp
 class Program {
    static void Main(string[] args){

        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Novo Nome";
    }
 }

```

#### Exercicio Classe 1

```csharp
using System;
 
class Pessoa 
{
    public string nome;
    public int idade;
    public string genero;

    public void Identificar()
    {
      Console.WriteLine($"Olá, sou o {nome} tenho {idade} e sou do sexo {genero}.");
    }
}
 
 
 class Program {
    static void Main(string[] args){
        Pessoa pessoa = new Pessoa();

        pessoa.nome = "Vinicius";
        pessoa.idade = 25;
        pessoa.genero = "Masculino";

        pessoa.Identificar();
        
    }

 }

```