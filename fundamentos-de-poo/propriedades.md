
# Propriedades em C#

As **propriedades** são membros de classes em C# que permitem ler, escrever ou calcular valores de forma mais flexível e controlada. Elas encapsulam um campo de uma classe e oferecem uma maneira de expor seus valores de maneira mais segura e controlada para o mundo externo.

## Estrutura Básica de uma Propriedade

Uma propriedade em C# consiste, geralmente, em um método de acesso `get` e um método de definição `set`. Esses métodos fornecem uma interface para leitura e escrita do valor do campo da classe.

### Exemplo

```csharp
public class Pessoa
{
    private string nome;

    // Propriedade pública para acessar o campo privado `nome`
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
}
```

### Funcionamento

1. **Get**: Retorna o valor do campo.
2. **Set**: Atribui um valor ao campo.

### Vantagens

- Controle sobre os valores atribuídos.
- Flexibilidade para mudanças futuras no armazenamento dos dados.

## Tipos de Propriedades

### 1. Propriedades Automáticas

As **propriedades automáticas** permitem que você crie uma propriedade sem precisar definir um campo privado explicitamente. O compilador cria automaticamente um campo privado anônimo que armazena o valor da propriedade.

```csharp
public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}
```

### Quando Utilizar

Utilize propriedades automáticas quando não há necessidade de lógica adicional para `get` ou `set`.

### 2. Propriedades Somente Leitura

Uma **propriedade somente leitura** define um valor no construtor ou em um campo de somente leitura (`readonly`), sendo útil quando deseja-se que o valor seja definido uma vez e não alterado posteriormente.

```csharp
public class Livro
{
    public string Titulo { get; }
    
    public Livro(string titulo)
    {
        Titulo = titulo;
    }
}
```

### 3. Propriedades Somente Gravação

Essas propriedades são incomuns em C#, mas é possível criá-las removendo o `get` da propriedade. Elas são usadas quando se deseja expor apenas a capacidade de definir um valor e não de lê-lo diretamente.

```csharp
public class Registro
{
    private string senha;
    
    public string Senha
    {
        set { senha = value; }
    }
}
```

### 4. Propriedades Calculadas

As **propriedades calculadas** não armazenam um valor, mas calculam-no no momento em que são acessadas, utilizando uma lógica definida no `get`.

```csharp
public class Retangulo
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public double Area
    {
        get { return Largura * Altura; }
    }
}
```

### 5. Propriedades Somente Get e Somente Set

- **Somente Get**: Utilizadas para fornecer acesso somente de leitura.
- **Somente Set**: Permitem que apenas o `set` seja definido externamente, como um método `WriteOnly`, onde apenas a classe pode ler o valor internamente.

## Modificadores de Acesso

Os modificadores de acesso permitem controlar quem pode acessar o `get` ou `set` de uma propriedade. Por exemplo, é possível ter um `get` público e um `set` privado:

```csharp
public class ContaBancaria
{
    public decimal Saldo { get; private set; }

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }
}
```

## Expressão Corporal para Propriedades (C# 6+)

C# 6 introduziu **expressões corporais** para simplificar as propriedades de somente leitura.

```csharp
public class Circulo
{
    public double Raio { get; set; }
    
    public double Area => Math.PI * Raio * Raio;
}
```

Essa sintaxe é uma maneira mais curta de definir uma propriedade `get` que retorna um valor calculado.

## Boas Práticas com Propriedades em C#

1. **Use propriedades automáticas** quando possível, para simplificar o código.
2. **Mantenha o encapsulamento** – evite expor campos diretamente; use propriedades.
3. **Valide entradas no `set`** – permite garantir que valores inválidos não sejam atribuídos.
4. **Use somente get quando necessário** – útil para expor dados calculados ou constantes.
5. **Considere o uso de `readonly` e `private set`** para propriedades que não devem ser modificadas externamente.


### Set
O método set de uma propriedade em C# para aplicar validações, assegurando que apenas valores válidos sejam atribuídos. Isso é útil para manter a consistência e integridade dos dados dentro de uma classe.<br/>

```csharp
public class Produto
{
    private decimal preco;

    public decimal Preco
    {
        get { return preco; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("O preço não pode ser negativo.");
            }
            preco = value;
        }
    }
}
```

#### Explicação do Código

**Campo privado preco**: Este é o campo real onde o valor é armazenado.<br/>
**Propriedade Preco com validação no set**:
O método set verifica se o valor é menor que zero.<br/>
Se o valor for negativo, ele lança uma exceção ArgumentException, impedindo a atribuição.<br/>
Se o valor for válido, ele é armazenado no campo preco.<br/>
Esse tipo de validação é bastante eficiente para garantir regras de negócio diretamente dentro da classe.<br/>

Benefícios do set com Validação<br/>
**Encapsulamento**: A validação no set permite que a classe controle os valores atribuídos aos seus campos.<br/>
**Redução de Erros**: Evita que valores inválidos sejam atribuídos e causem erros mais adiante.<br/>
**Manutenção de Regras de Negócio**: Regras importantes para a aplicação podem ser asseguradas diretamente na classe, evitando a necessidade de validação externa.<br/>
**Você pode usar esse mesmo padrão para outros tipos de validação, como**:

Verificar comprimentos mínimos/máximos de string,
Limitar intervalos de valores numéricos,
Validar formatos de dados (como emails ou números de telefone)