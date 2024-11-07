# Métodos

Um método é um **bloco de código** que contém uma série de **instruções**.

Um programa faz com que as instruções sejam executadas chamando o método e espeficicando **os argumentos** de método necessários.

Na linguagem C#, todas as instruções executadas são realizadas no contexto de um método que são declarados em uma **classe**.

Namespace <br/>
Classe <br/>
Método -> 

<br/>

```csharp
    public void Metodo()
    {
        //instrução
    }
```
<br/>

```csharp
    public int Metodo(int param)
    {
        //Instrução
    }
```


## Método: Sobrecarga ou Overloading

```csharp
class Teste 
{
    public init Somar(int numero1, int numero2)
    {
        return numero1 + numero2;
    }

    public double Somar(double numero1, int numero2, int numero3)
    {
        return numero1+numero2+numero3;

    }

    public int Somar(params int[] numeros)
    {
        //código
    }
}

```


### Métodos - Parâmetros opcionais

Na linhagem C# os métodos podem conter parâmetros obrigatórios e também **parâmetros opcionais**.

Um método com parâmetros opcionais pode ser chamado **sem obrigação de passar argumetos** para esses parâmetros.


Em C#, métodos podem ter parâmetros opcionais, o que permite definir valores padrão para esses parâmetros. Quando você define um parâmetro como opcional, ele pode ser omitido na chamada do método, e o valor padrão será usado.


#### Estrutura básica
Para definir um parâmetro opcional em C#, você apenas precisa atribuir um valor a ele no método. Veja o exemplo:



### Exemplos:

```chsarp
public void ExibirMensagem(string mensagem, int repeticoes = 1)
{
    for (int i = 0; i < repeticoes; i++)
    {
        Console.WriteLine(mensagem);
    }
}

```

```csharp
ExibirMensagem("Olá, mundo!");
// Saída:
// Olá, mundo!

```
```csharp
// Correto
public void MetodoExemplo(int obrigatorio, string opcional = "valor padrão") { }

// Incorreto
public void MetodoExemplo(string opcional = "valor padrão", int obrigatorio) { }
```

### Outros exemplos:

```csharp
public void Saudar(string nome, string saudacao = "Olá")
{
    Console.WriteLine($"{saudacao}, {nome}!");
}

// Uso
Saudar("Maria");             // Saída: Olá, Maria!
Saudar("João", "Bem-vindo"); // Saída: Bem-vindo, João!

```


# Argumentos

Por padrão a chamada de método requer que passemos os argumentos respeitando o posicionamento dos parâmetros, lista de parâmetros definidos no método.

```csharp
public static void Enviar(string destino, string titulo, string assunto)
{
    Console.WriteLine($"{destino}, {titulo}, {assunto}");
}

Enviar("vinicius@contato.com", "contato", "Gentileza entrar em contato");
```

<p>Se não seguirmos essa regra teremos problemas na execução do método com <strong>valores trocados</strong> ou erro de <strong>tipos de dados</strong> definidos incorretamente.</p>

## Argumentos Nomeados

<p>Permitem especificar um argumento para um determinado parâmetro associando o <strong>argumento</strong> com o <strong>nome</strong> do parâmetro ao invés da <strong>posição do parâmetro</strong>.</p>

## Métodos Estáticos

<p>A linguagem C# palavra-chave <strong>static</strong> pode ser aplicada a classes, variáveis, métodos, eventos, construtores. O modificador static torna um item não instanciável.</p>

```csharp
class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, mundo!");
        Console.ReadLine();
    }
}
```

<ol>
<li>Mas onde está a instância da classe Console?</li>
<li>Como podemos acessar os métodos WriteLine e ReadLine sem criar uma instância da classe Console?</li>
</ol> </br>

<p>A resposta é que, a palavra-chave <strong>static</strong> faz com que os métodos da classe Console estejam associados à classe e <strong>não</strong> a uma instância particular dessa classe.</p>

<h3>Problemas com Métodos Estáticos</h3>

<ul></br>
<li><strong>Dificultam Testes:</strong> Métodos estáticos não podem ser substituídos ou "mockados" em testes unitários, dificultando o teste isolado e o uso de injeção de dependências.</li>
<li><strong>Aumentam o Acoplamento:</strong> Código que depende de métodos estáticos fica fortemente acoplado à classe, limitando a extensibilidade e reduzindo a flexibilidade para mudanças.</li>
<li><strong>Falta de Estado e Contexto:</strong> Métodos estáticos não acessam o estado de instância, exigindo que todas as informações sejam passadas via parâmetros, o que pode gerar código mais verboso.</li>
<li><strong>Problemas de Concorrência:</strong> Métodos estáticos compartilham o mesmo estado entre todas as chamadas, tornando-os potencialmente inseguros para acesso concorrente.</li>
</ul>


## Métodos de extensão

São definidos como estáticos, mas não são chamamados, usando a sintaxe do **método de instância**.

Seu primeiro parâmetro especifica em que tipo o método opera e o perâmetro é precedido pelo modificador **this**

Estarão no escopo somente quando você importar o **namespace** para o seu código fonte.


```csharp
public static string metodoExtensao(this string valor)
{
    //
}
```

### Implementação de um método de extensão

```csharp
//Classe estática
public static class MetodoExtensao
{
    //Método estático
    //Primeiro parâmetro do método define o tipo que estamos estendendo - string
    //Deve estar procedido de this
    public static string CaixaAltaPrimeiraLetra(this string valor)
    {
        if (valor.Length > 0)
        {
            char[] array = valor.ToCharArray();
            array[0] = char.ToUpper(array[0]);
            return new string(array);
        }

        return valor;
    }
}
```