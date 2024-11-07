
# Casting em C# - Upcasting e Downcasting

Em C#, **casting** é o processo de converter uma variável de um tipo para outro. Com a Programação Orientada a Objetos e herança, há dois tipos comuns de casting: **Upcasting** e **Downcasting**.

## 1. Upcasting

O **Upcasting** é o processo de converter uma classe derivada para uma classe base. Em outras palavras, é a conversão de um tipo mais específico para um tipo mais genérico.

### Exemplo de Upcasting

Vamos criar uma classe base chamada `Veiculo` e duas classes derivadas: `Carro` e `Moto`.

```csharp
public class Veiculo
{
    public string Marca { get; set; }
    public void Mover()
    {
        Console.WriteLine("O veículo está se movendo.");
    }
}

public class Carro : Veiculo
{
    public int NumeroDePortas { get; set; }
    public void AbrirPortas()
    {
        Console.WriteLine("Abrindo as portas do carro.");
    }
}

public class Moto : Veiculo
{
    public bool TemCarenagem { get; set; }
    public void Empinar()
    {
        Console.WriteLine("A moto está empinando.");
    }
}
```

### Uso de Upcasting

Com o Upcasting, podemos tratar objetos `Carro` e `Moto` como objetos `Veiculo`:

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Carro carro = new Carro();
        Veiculo veiculo = carro; // Upcasting

        veiculo.Mover(); // Funciona, pois Mover é definido em Veiculo
        // veiculo.AbrirPortas(); // Erro, pois AbrirPortas não está em Veiculo
    }
}
```

### Explicação

- No **Upcasting**, `veiculo` é tratado como um `Veiculo`, o que significa que apenas os membros definidos em `Veiculo` estão acessíveis.
- Métodos específicos da classe `Carro`, como `AbrirPortas`, não estão disponíveis após o upcasting.

## 2. Downcasting

O **Downcasting** é o processo de converter uma classe base para uma classe derivada. Em outras palavras, é a conversão de um tipo mais genérico para um tipo mais específico.

> Nota: Downcasting deve ser feito com cuidado. Se o objeto não for realmente uma instância do tipo de destino, ocorrerá uma exceção `InvalidCastException`.

### Exemplo de Downcasting

Para o Downcasting, precisamos primeiro fazer o Upcasting para um tipo base e depois converter de volta ao tipo derivado.

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Veiculo veiculo = new Carro(); // Upcasting
        Carro carro = (Carro)veiculo; // Downcasting

        carro.AbrirPortas(); // Funciona, pois carro é do tipo Carro
    }
}
```

### Verificação de Tipos com `is` e `as`

Ao fazer Downcasting, é importante verificar se o objeto pode realmente ser convertido para o tipo desejado. Em C#, usamos os operadores `is` e `as` para isso.

#### Usando `is`

```csharp
if (veiculo is Carro)
{
    Carro carro = (Carro)veiculo;
    carro.AbrirPortas();
}
```

#### Usando `as`

```csharp
Carro carro = veiculo as Carro;
if (carro != null)
{
    carro.AbrirPortas();
}
```

## Diferença entre Upcasting e Downcasting

| Aspecto           | Upcasting                                     | Downcasting                                     |
|-------------------|-----------------------------------------------|-------------------------------------------------|
| Direção           | Específico para genérico                      | Genérico para específico                        |
| Segurança         | Seguro, não requer verificação                | Pode lançar exceções, precisa de verificação    |
| Acessibilidade    | Acesso apenas aos membros da classe base      | Acesso aos membros da classe derivada           |

### Conclusão

- **Upcasting** é geralmente seguro e permite tratar objetos derivados como objetos da classe base, o que é útil para generalização.
- **Downcasting** deve ser feito com cautela, pois pode lançar exceções se o tipo não for compatível.


