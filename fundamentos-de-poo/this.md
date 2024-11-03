### A Palavra this em C#

1 - Refere-se á instância atual da classe
2 - É usada  como um modificador do primeiro parÂmetro de um método de extensão.


Principais usos:
1 - Qualificar membros ocultados por nomes semelhantes(evitar ambiguidade)
2- Para passar um objeto como parâmetro para outros métodos.

#### Caso de uso 1. Qualificando membros ocultados. Evitando ambiguidade.
```csharp
class Funcionario 
{
    public string Nome {get; set;}
    public string Email {get; set;}
}
public Funcionario(string Nome, string Email)
{
    //Use this para qualificar as propriedades
    //Nome e Email, evitando confusão com os nomes dos parametros usados no construtor

    this.Nome = Nome;
    this.Email = Email;
}

```


#### Caso de uso 2.Passando objeto como parâmetro para outros métodos.
```csharp
class Test 
{
    public string Nome {get; set;}
    public Test()
    {

        this.Nome = exemplo.Nome;
    }
}

class Exemplo
{
    public string Nome {get; set;}
    public Exemplo()
    {
        this.Nome = nome;

        Test test = new Test(this);

        Console.WriteLine(test.Nome);
    }
}

```
