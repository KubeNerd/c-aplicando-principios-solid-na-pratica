# Encapsulamento e Modelo de domínio em C#

**Encapsular** é ocultar os detalhes da implantação de um objeto de forma manter o seu estado consistente.<br/>


O **Modelo de domínio** é uma representação de classes conceituais a partir do mundo real.<br/>


### Exemplo de modelo de domínio
```csharp
class public DomainExceptionValidation: Exception
{
    public DomainExceptionValidation(string error)
    : base(error)
    {
        if(hasError)
        {
            throw new DomainExceptionValidation(error);
        }
    }
}


public class Client 
{

    public int Id { get; private set;}
    public string Nome { get; private set;}
    public string Endereco { get; private set; }

    public Client(int id, string nome, string endereco)
    {
        DomainExceptionValidation.When(id < 0, "");
        DomainExceptionValidation.When(stringIsNullOrEmpty(nome), "O nome deve ser informado");
        DomainExceptionValidation.When(stringIsNullOrEmpty(nome), "O nome deve ser informado");
    
        Id = id;
        Nome = nome;
        Endereco = endereco;
    }
}

```