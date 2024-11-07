
# Curso Completo de Expressões Lambda em C#

Este curso vai te guiar pelo conceito de **Expressões Lambda em C#**, explicando desde o básico até o uso avançado. Lambdas são uma parte essencial da programação funcional e oferecem uma maneira poderosa e concisa de manipular dados.

---

## Introdução às Expressões Lambda

Uma **Expressão Lambda** é uma função anônima que você pode usar para criar métodos de forma concisa e eficiente em C#. Lambdas permitem definir funções inline que podem ser passadas como parâmetros.

### Sintaxe Básica

A sintaxe de uma expressão lambda em C# é a seguinte:

```csharp
(parametros) => expressão
```

- **Parâmetros**: São os argumentos que a expressão lambda recebe.
- **Seta** (`=>`): Separa os parâmetros da expressão.
- **Expressão**: O corpo da função que será executado.

Exemplo básico:

```csharp
int resultado = numeros.Count(n => n > 5);
```

Neste exemplo, `n => n > 5` é uma expressão lambda que retorna `true` para números maiores que 5.

---

## Vantagens das Expressões Lambda

1. **Código Mais Limpo**: Reduz a quantidade de código boilerplate.
2. **Flexibilidade**: Facilita o uso de programação funcional, aumentando a flexibilidade e legibilidade.
3. **Maior Modularidade**: Funções podem ser passadas como parâmetros, melhorando a modularidade.

---

## Tipos de Expressões Lambda

### 1. Lambda de Uma Linha

Se a expressão lambda tiver apenas uma linha, você pode omitir as chaves e o tipo de retorno:

```csharp
(x, y) => x + y;
```

### 2. Lambda com Corpo de Bloco

Para expressões mais complexas, você pode usar chaves `{}` para definir um bloco de código.

```csharp
(x, y) => {
    int soma = x + y;
    return soma * 2;
}
```

### 3. Lambdas com Tipo de Dados Explícito

Por padrão, o compilador infere o tipo dos parâmetros, mas você pode declarar explicitamente:

```csharp
(int x, int y) => x + y;
```

---

## Uso de Lambda com Delegates

Expressões lambda podem ser atribuídas a delegados. Por exemplo:

```csharp
Func<int, int, int> soma = (a, b) => a + b;
Console.WriteLine(soma(2, 3)); // Saída: 5
```

No exemplo acima, estamos usando o delegate `Func`, que aceita dois inteiros e retorna um inteiro.

---

## Uso de Lambda com LINQ

O LINQ (Language Integrated Query) é uma das áreas onde as expressões lambda brilham em C#.

Exemplo de uso com LINQ:

```csharp
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };
var numerosPares = numeros.Where(n => n % 2 == 0).ToList();

// Saída: [2, 4, 6]
```

Aqui, `n => n % 2 == 0` é uma expressão lambda que filtra números pares.

---

## Operadores Lambda em Expressões Comuns

1. **Count**: Conta elementos que satisfazem uma condição.

    ```csharp
    int count = numeros.Count(n => n > 3);
    ```

2. **Select**: Transforma elementos de uma coleção.

    ```csharp
    var quadrados = numeros.Select(n => n * n);
    ```

3. **Any**: Verifica se qualquer elemento satisfaz uma condição.

    ```csharp
    bool existe = numeros.Any(n => n < 0);
    ```

4. **FirstOrDefault**: Retorna o primeiro elemento que satisfaz uma condição, ou valor padrão.

    ```csharp
    int primeiroPar = numeros.FirstOrDefault(n => n % 2 == 0);
    ```

---

## Lambdas em Expressões Avançadas

### Captura de Variáveis

Lambdas podem capturar variáveis de seu escopo externo. Isso é conhecido como **Closure**.

```csharp
int multiplicador = 3;
Func<int, int> multiplicacao = x => x * multiplicador;
Console.WriteLine(multiplicacao(4)); // Saída: 12
```

### Lambdas e Delegates Personalizados

Você pode criar um delegate personalizado para usar com lambdas:

```csharp
public delegate bool Filtro<T>(T item);

List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
Filtro<int> filtro = n => n > 3;

var filtrados = numeros.Where(n => filtro(n)).ToList(); // Saída: [4, 5]
```

---

## Boas Práticas com Lambdas

1. **Evite Expressões Complexas**: Lambdas devem ser concisas; use blocos apenas quando necessário.
2. **Nomeie Variáveis de Forma Clara**: Mesmo que sejam curtas, as variáveis devem ser descritivas.
3. **Use Lambdas para Simplicidade**: Não exagere; em casos complexos, considere usar métodos nomeados.

---

## Exercícios

1. Crie uma lista de inteiros e use lambdas para:
    - Filtrar números pares
    - Somar todos os números maiores que 10
    - Verificar se algum número é negativo

2. Use lambdas para manipular uma lista de strings:
    - Transforme todas as strings em letras maiúsculas
    - Filtre strings com mais de 5 caracteres

3. Crie um delegate personalizado e use uma expressão lambda para filtrar uma lista.
