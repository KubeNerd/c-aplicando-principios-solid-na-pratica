## Argumentos

Por padrão a chamada de método requer que passemos os argumentos respeitando o posicionamento dos parâmetros, lista de parâmetros definidos no método.


```csharp
public static void Enviar(string destino, string titulo, string assunto)
{
    Console.WriteLine($"{destino}, {titulo}, {assunto}");
}

Enviar("vinicius@contato.com", "contato", "Gentileza entrar em contato");
```

Se não seguirmos essa regra teremos problemas na execução do método  com **valores trocados** ou erro de **tipos de dados** definidos incorretamente.


### Argumentos nomeados

Permitem espeficicar um argumento para um determinado parâmetro associando o **argumento** com o **nome** do parâmetro ao invés **da posição do parâmetro**.
