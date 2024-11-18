# Acoplamento Forte

No acoplamento forte os componentes são interconectados de uma forma tão dependente que é praticamente impossível alterar um deles sem **causar efeitos colaterais** em todo ou em grande parte do sistema.

- No acoplamento forte as classes e os objetos **são dependentes um do outro** e, portanto, reduzem a reutilização do código.

- Uma classe com acoplamento forte **depende de muitas outras classes** para fazer o seu serviço;

- Uma classe com acoplamento forte é mais **difícil de manter, de entender e de ser reusada**.



# Acoplamento Fraco

No acoplamento fraco os componentes de um sistema são interconectados de modo que um dependa do outro o **mínimo possível**;

- Uma classe com acoplamento fraco **não é dependente de muitas classes** para fazer o que ele tem que fazer;

- Uma classe com acoplamento fraco é mais **fácil de manter, de entender e de ser reusada**.

# Vantagens do Acoplamento Fraco

- O acoplamento fraco é preferido ao forte, uma vez que alterar uma classe não afetará outra.

- Reduz dependências em uma classe e isso facilita a reutilização de código.

## Vantagens

- Um módulo não quebra outros módulos;
- Melhora a testabilidade do sistema;
- O código é mais fácil de manter;
- Fica menos afetado por alterações em outros componentes.



# Nível de acoplamento dos relacionamentos entre classes

- **Herança** - possui o acoplamento mais forte de todos
- **Composição** - possui um acoplamento mais fraco que herança
- **Agregação** - possui o acoplamento mais fraco de todos

## Conclusão

> **Prefira usar composição ao invés de herança quando possível**


# Problemas da Herança

1. Ao usar herança estamos violando um dos pilares da orientação a objetos: o **encapsulamento**, visto que os detalhes da implementação da classe Pai são expostos nas classes Filhas;

2. Ao usar herança estamos violando um dos princípios básicos das boas práticas de programação: manter o **acoplamento** entre as classes **fraco**, visto que as classes filhas estão fortemente acopladas à classe Pai e alterar uma classe Pai pode afetar todas as classes Filhas;

3. As **implementações** herdadas da classe Pai pelas classes Filhas não podem ser alteradas em tempo de execução;


# Vantagens da Composição

1. Os objetos que foram instanciados estão contidos na **classe que os instanciou** e são acessados somente através de sua **interface**;

2. Pode ser definida dinamicamente em **tempo de execução** pela obtenção de referência de objetos a **objetos do mesmo tipo**;

3. Apresenta uma **menor dependência** de implementações;

4. Cada classe focada em apenas **uma tarefa** (princípio SRP);

5. Temos um bom **encapsulamento** visto que os detalhes internos dos objetos instanciados não são visíveis;


## Herança vs Composição

Antes de mais nada, é importante lembrar que a composição é um princípio fundamental da orientação a objetos que consiste em construir objetos complexos combinando outros objetos mais simples e reutilizáveis. Em vez de depender de uma hierarquia de classes (como na herança), a composição estabelece que os objetos devem "ter" outras classes ou comportamentos, criando relações "tem um" (e não "é um").


## Usando a herança
```csharp
using System;

class Veiculo
{
    public int Velocidade { get; set; }

    public Veiculo(int velocidade)
    {
        Velocidade = velocidade;
    }

    public virtual void Mover()
    {
        Console.WriteLine($"O veículo está se movendo a {Velocidade} km/h");
    }
}

class Carro : Veiculo
{
    public string Combustivel { get; set; }

    public Carro(int velocidade, string combustivel) : base(velocidade)
    {
        Combustivel = combustivel;
    }

    public void TipoCombustivel()
    {
        Console.WriteLine($"O carro usa {Combustivel}");
    }
}

class Bicicleta : Veiculo
{
    public string Tipo { get; set; }

    public Bicicleta(int velocidade, string tipo) : base(velocidade)
    {
        Tipo = tipo;
    }

    public void TipoBicicleta()
    {
        Console.WriteLine($"Essa é uma bicicleta {Tipo}");
    }
}

class Program
{
    static void Main()
    {
        Carro carro = new Carro(120, "Gasolina");
        carro.Mover();
        carro.TipoCombustivel();

        Bicicleta bicicleta = new Bicicleta(25, "de corrida");
        bicicleta.Mover();
        bicicleta.TipoBicicleta();
    }
}

```

**Problemas com Herança**:
    - A classe base Veiculo impõe uma estrutura fixa que pode ser difícil de modificar para novos tipos de veículos.
    - Se quisermos adicionar novos comportamentos, como "Transporte de carga", teremos que modificar a hierarquia inteira.


## Usando a Composição

```csharp
using System;

class Movimento
{
    public int Velocidade { get; set; }

    public Movimento(int velocidade)
    {
        Velocidade = velocidade;
    }

    public void Mover()
    {
        Console.WriteLine($"O veículo está se movendo a {Velocidade} km/h");
    }
}

class Combustivel
{
    public string Tipo { get; set; }

    public Combustivel(string tipo)
    {
        Tipo = tipo;
    }

    public void TipoCombustivel()
    {
        Console.WriteLine($"Esse veículo usa {Tipo}");
    }
}

class Bicicleta
{
    public Movimento Movimento { get; set; }
    public string Tipo { get; set; }

    public Bicicleta(int velocidade, string tipo)
    {
        Movimento = new Movimento(velocidade);
        Tipo = tipo;
    }

    public void TipoBicicleta()
    {
        Console.WriteLine($"Essa é uma bicicleta {Tipo}");
    }
}

class Carro
{
    public Movimento Movimento { get; set; }
    public Combustivel Combustivel { get; set; }

    public Carro(int velocidade, string combustivel)
    {
        Movimento = new Movimento(velocidade);
        Combustivel = new Combustivel(combustivel);
    }
}

class Program
{
    static void Main()
    {
        Carro carro = new Carro(120, "Gasolina");
        carro.Movimento.Mover();
        carro.Combustivel.TipoCombustivel();

        Bicicleta bicicleta = new Bicicleta(25, "de corrida");
        bicicleta.Movimento.Mover();
        bicicleta.TipoBicicleta();
    }
}

```

**Vantagens da Composição**:
- As classes Movimento e Combustivel podem ser reutilizadas em diferentes objetos (não apenas Carro ou Bicicleta).<br/>

- Modificar ou substituir funcionalidades, como alterar o tipo de movimento ou combustível, não exige mudanças na hierarquia inteira.<br/>
O código segue o princípio de responsabilidade única (SRP), tornando-o mais fácil de testar e manter.



## Modificador `sealed` - Classes

Uma **classe selada** utiliza o modificador `sealed` e impede que outras classes **herdem** desta classe. *(não pode atuar como uma classe base).*

```csharp
<modificador> sealed class <nome_da_classe>
{
    // código da classe
}
```

- São usadas para restringir o recurso de herança.
- Elas podem ser consideradas o oposto das classes abstratas.
- Podem ser instanciadas e usadas normalmente




# Modificador `sealed` – Métodos e Propriedades

Podemos usar o modificador `sealed` em um **método** ou **propriedade** que substitui (`override`) um método ou propriedade **virtual** em uma **classe base**.

Isso permite que classes sejam derivadas de sua classe e **impede** que elas substituam métodos ou propriedades **virtuais**.

- Um método selado (`sealed`) **não pode ser substituído** (`override`).
- Para declarar um método como selado, ele tem que ser declarado **virtual** na sua classe base.
- Quando aplicado, o modificador `sealed` **sempre deve ser usado com `override`**.

### Exemplo:

```csharp
class ClasseBase
{
    public virtual void MetodoVirtual()
    {
        Console.WriteLine("Método virtual na classe base.");
    }
}

class ClasseDerivada : ClasseBase
{
    public sealed override void MetodoVirtual()
    {
        Console.WriteLine("Método selado na classe derivada.");
    }
}

class OutraClasseDerivada : ClasseDerivada
{
    // Erro! Não é possível substituir o método selado.
    // public override void MetodoVirtual()
    // {
    //     Console.WriteLine("Não permitido!");
    // }
}

```


## Polimorfismo

A Palavra Polimorfismo significa "várias formas". Ocorre quando há um relacionamento de Herança entre as classes(É um).

"**Polimorfismo** é o princípio pelo qual duas ou mais classes derivadas de uma mesma superclasse podem invocar métodos que têm a mesma assinatura mas comportamentos distintos, que são especializadas para cada classe derivada, usando


## Polimorfisco com herença
 - Classes derivadas sobrescrevendo membros da classe base.

## Polimorfismo com interface
 - Classes que implementam a interface com comportamente diferente.
 - Métodos com o mesmo nome nas classes mas funcionalidades diferentes.


# Polimorfismo com classe abstrata
 - As classes derivadas incluem os detalhes de implementação nos métodos abstratos.
