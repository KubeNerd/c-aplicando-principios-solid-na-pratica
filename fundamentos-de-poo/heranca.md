# Herança
Oque é herança ?

Na linguagem csharp, é possível herdar membros(campos, propriedades e métodos) de uma classe para outra.


Herança é a capacidade de criar uma classe base com membros(campos, propriedades e métodos) que podem ser usados em classes derivadas da classe base.

1 - Classe derivada(filha ou subclasse) - a classe que herda de outra classe.

2 - Classe base(pai ou superclasse) - a classe que está ssendo herdada.

Para indicar a herança, ou seja para headar uma classe, usamos o símbolo :

```csharp
class classeDerivada: ClasseBase
{

}
```

1 - Classe derivada(filha/subclasse) - classe que herda de outra classe.
2 - Classe base(pai/superclasse) - a classe que está sendo herdada.

Por meio de herança, uma classe hera as propriedades do método de uma outra classe podendo assim estender ou modificar o comportamento da sua funcionalidade.

Um dos principais benefícios da herança, é o reaproveitamento de código.

```csharp
class Conta
{
    public int Numero {get; set;}
    public double Saldo {get; set;}
}


class ContaPoupanca
{
    public int Numero {get; set;}
    public double Saldo {get; set;}
    public int JurosMensais {get; set;}
}
```

</br>

Todos os mebros públicos(campos, propriedades, métodos) são herdados.
(Membros privados não são herdados)

O Modificador de acesso protected torna um membro de  uma classe base somente acessível as suas classes derivadas;

Membros internos são visíveis apenas em casses derivadas localizadas no assembry que a classe base.



# Herança e Construtor em C#

Este diagrama ilustra a ordem de execução dos construtores na herança em C#. O construtor da classe base é executado primeiro, seguido pelo construtor da classe derivada.

```plaintext
Classe Veiculo                Classe Carro
┌─────────────────┐           ┌──────────────────┐
│ public Veiculo()│           │ public Carro()   │
│ {               │           │ {                │
│   Console.Write │           │   Console.Write  │
│   Line("Inicial │           │   Line("Iniciali │
│   izando Veicu  │           │   zando Carro"); │
│   lo");         │           │ }                │
└─────────────────┘           └──────────────────┘
          ↑                              │
          │                              │
          └─────────────┬───────────────►│
                        │
```

## Explicação

- Quando `Carro` é instanciado, o construtor da classe base `Veiculo` é chamado primeiro.
- Após a execução do construtor de `Veiculo`, o construtor da classe `Carro` é executado.

Exemplo no código principal:

```csharp
static void Main(string[] args)
{
    var carro = new Carro(); // Executa Veiculo() primeiro, depois Carro()
    Console.ReadLine();
}
```

<br/>

Este diagrama mostra claramente a sequência de execução dos construtores e reforça que a classe base sempre é inicializada antes da classe derivada.


# Herança em C#

A herança é um dos pilares da Programação Orientada a Objetos (POO), permitindo que uma classe (`filha`) herde atributos e métodos de outra classe (`pai`). Isso promove reutilização de código e facilita a extensão e modificação de funcionalidades.

Neste exemplo, vamos criar uma classe base chamada `Veiculo` e duas classes derivadas: `Carro` e `Moto`. Exploraremos como métodos e propriedades são herdados e modificados nas classes filhas.

## Estrutura das Classes

1. **Classe Base `Veiculo`**: Contém um construtor que inicializa a classe e um método público `Mover` que será sobrescrito nas classes derivadas.
2. **Classes Derivadas `Carro` e `Moto`**: Herdam de `Veiculo` e sobrescrevem o método `Mover` para implementar um comportamento específico.
3. **Método Privado**: Vamos criar um método privado na classe base e implementar um mecanismo para acessá-lo nas classes filhas.

## Código

```csharp
using System;

public class Veiculo
{
    public string Marca { get; set; }
    public int Ano { get; set; }

    // Construtor da classe base
    public Veiculo(string marca, int ano)
    {
        Marca = marca;
        Ano = ano;
        Console.WriteLine("Inicializando Veiculo");
    }

    // Método privado que só pode ser acessado na classe base
    private void Diagnostico()
    {
        Console.WriteLine("Diagnóstico de veículo realizado.");
    }

    // Método protegido para acessar o método privado nas classes filhas
    protected void RealizarDiagnostico()
    {
        Diagnostico(); // Acessa o método privado
    }

    // Método virtual que será sobrescrito nas classes derivadas
    public virtual void Mover()
    {
        Console.WriteLine("O veículo está se movendo.");
    }
}

public class Carro : Veiculo
{
    public int NumeroDePortas { get; set; }

    public Carro(string marca, int ano, int numeroDePortas)
        : base(marca, ano) // Chama o construtor da classe base
    {
        NumeroDePortas = numeroDePortas;
        Console.WriteLine("Inicializando Carro");
    }

    // Sobrescrevendo o método Mover
    public override void Mover()
    {
        Console.WriteLine("O carro está dirigindo na estrada.");
    }

    // Método para executar diagnóstico específico do Carro
    public void DiagnosticoCarro()
    {
        RealizarDiagnostico(); // Usa o método protegido para acessar o método privado na classe base
        Console.WriteLine("Diagnóstico adicional para carro concluído.");
    }
}

public class Moto : Veiculo
{
    public bool TemCarenagem { get; set; }

    public Moto(string marca, int ano, bool temCarenagem)
        : base(marca, ano) // Chama o construtor da classe base
    {
        TemCarenagem = temCarenagem;
        Console.WriteLine("Inicializando Moto");
    }

    // Sobrescrevendo o método Mover
    public override void Mover()
    {
        Console.WriteLine("A moto está acelerando na pista.");
    }

    // Método para executar diagnóstico específico da Moto
    public void DiagnosticoMoto()
    {
        RealizarDiagnostico(); // Usa o método protegido para acessar o método privado na classe base
        Console.WriteLine("Diagnóstico adicional para moto concluído.");
    }
}
```

### Explicação do Código

1. **Construtor**:
   - A classe base `Veiculo` possui um construtor que inicializa as propriedades `Marca` e `Ano`.
   - As classes derivadas `Carro` e `Moto` usam o operador `base` para chamar o construtor da classe `Veiculo`, garantindo que a inicialização aconteça de forma adequada.

2. **Método Privado e Protegido**:
   - `Veiculo` possui um método privado chamado `Diagnostico`, que executa um diagnóstico simples.
   - Para permitir o acesso ao método `Diagnostico` nas classes derivadas, criamos um método protegido `RealizarDiagnostico`, que chama o método privado. Assim, `RealizarDiagnostico` pode ser usado nas classes derivadas para acessar a funcionalidade do método privado de forma indireta.

3. **Método Virtual e Override**:
   - `Veiculo` define um método `Mover` marcado como `virtual`, o que permite que as classes filhas o sobrescrevam.
   - `Carro` e `Moto` sobrescrevem `Mover` usando `override`, fornecendo implementações específicas para cada tipo de veículo.

### Uso no Método Principal

Abaixo, mostramos como instanciar as classes e usar os métodos definidos:

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Veiculo carro = new Carro("Toyota", 2020, 4);
        carro.Mover(); // Saída: "O carro está dirigindo na estrada."

        Veiculo moto = new Moto("Yamaha", 2019, true);
        moto.Mover(); // Saída: "A moto está acelerando na pista."

        Carro meuCarro = new Carro("Honda", 2021, 4);
        meuCarro.DiagnosticoCarro(); // Saída: Diagnóstico de veículo realizado + Diagnóstico adicional para carro concluído.

        Moto minhaMoto = new Moto("Suzuki", 2022, true);
        minhaMoto.DiagnosticoMoto(); // Saída: Diagnóstico de veículo realizado + Diagnóstico adicional para moto concluído.
    }
}
```

### Saída Esperada

Ao rodar o código acima, a saída será:

```
Inicializando Veiculo
Inicializando Carro
O carro está dirigindo na estrada.
Inicializando Veiculo
Inicializando Moto
A moto está acelerando na pista.
Inicializando Veiculo
Inicializando Carro
Diagnóstico de veículo realizado.
Diagnóstico adicional para carro concluído.
Inicializando Veiculo
Inicializando Moto
Diagnóstico de veículo realizado.
Diagnóstico adicional para moto concluído.
```

### Explicação Final

1. **Construtor da Classe Base**: É sempre executado primeiro antes do construtor da classe derivada. Isso garante que as propriedades e inicializações da classe base estejam definidas antes de adicionar detalhes específicos na classe filha.
2. **Método Privado e Protegido**: Usando um método protegido (`RealizarDiagnostico`), conseguimos acessar um método privado (`Diagnostico`) na classe base de dentro das classes derivadas, mantendo a segurança dos dados e métodos da classe base.
3. **Override do Método Virtual**: Cada classe derivada (`Carro` e `Moto`) fornece sua própria implementação do método `Mover`, mostrando a capacidade de personalizar o comportamento das classes derivadas usando polimorfismo.

