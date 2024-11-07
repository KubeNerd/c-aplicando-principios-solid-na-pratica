
# Modelo Anêmico em C#

O **Modelo Anêmico** é uma abordagem de design onde as classes de domínio contêm apenas propriedades e poucos ou nenhum comportamento (métodos). Em vez de centralizar a lógica de negócios nas próprias entidades de domínio, esta abordagem move essa lógica para classes de serviço, criando um modelo mais "passivo".

## Características Principais

- **Classes de Domínio**: Contêm apenas **propriedades** para armazenar dados, sem métodos complexos.
- **Classes de Serviço**: Centralizam a **lógica de negócios** que seria normalmente encontrada nas entidades de domínio.
- **Separação de Responsabilidades**: Entidades de domínio são usadas apenas para armazenar dados, enquanto classes de serviço manipulam esses dados e aplicam regras de negócio.

## Exemplo Básico em C#

Imagine um sistema simples para gerenciar informações de clientes e seus pedidos. Usando o modelo anêmico, a estrutura seria algo como:

### Classe de Domínio (Anêmica)

```csharp
public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    // Apenas propriedades para armazenar dados
}

public class Pedido
{
    public int Id { get; set; }
    public DateTime DataPedido { get; set; }
    public decimal ValorTotal { get; set; }
    public int ClienteId { get; set; }
    // Sem métodos, apenas dados
}
```

### Classe de Serviço

```csharp
public class ClienteService
{
    public void AtualizarEmail(Cliente cliente, string novoEmail)
    {
        // Lógica para atualizar o e-mail
        if (!novoEmail.Contains("@"))
        {
            throw new ArgumentException("Email inválido.");
        }
        cliente.Email = novoEmail;
    }
}

public class PedidoService
{
    public void ProcessarPedido(Pedido pedido)
    {
        // Lógica para processar o pedido
        if (pedido.ValorTotal <= 0)
        {
            throw new ArgumentException("Valor do pedido deve ser positivo.");
        }
        // Processamento adicional
    }
}
```

## Vantagens do Modelo Anêmico

1. **Simplicidade**: Entidades de domínio são fáceis de criar, pois contêm apenas dados.
2. **Separa Lógica de Negócio**: Facilita a localização de lógica de negócio nas classes de serviço, separando dados de comportamento.
3. **Flexibilidade**: Classes de serviço podem ser reutilizadas em diferentes contextos ou por outras classes de domínio.

## Desvantagens do Modelo Anêmico

1. **Desvio do DDD (Domain-Driven Design)**: No DDD, é recomendado que as entidades de domínio sejam "ricas" em comportamento. O modelo anêmico vai contra essa ideia.
2. **Aumento na Complexidade**: Pode gerar um código mais difícil de manter em sistemas grandes, pois a lógica se espalha por diversas classes de serviço.
3. **Baixa Coesão nas Entidades**: A entidade passa a ser apenas um repositório de dados, perdendo o conceito de encapsulamento e coesão.

## Quando Usar o Modelo Anêmico

O modelo anêmico é adequado para **sistemas simples** ou quando a **lógica de negócio é mínima**. Em sistemas onde as regras de negócio são complexas ou onde a abordagem do DDD é necessária, o modelo anêmico pode não ser ideal.



# Modelo Rico em C#

O **Modelo Rico** é uma abordagem de design onde as classes de domínio contêm tanto propriedades quanto a lógica de negócios. Ao contrário do Modelo Anêmico, no qual a lógica é centralizada em classes de serviço, no Modelo Rico as entidades de domínio são responsáveis por suas próprias regras e comportamentos. Isso promove encapsulamento e uma maior coesão.

## Características Principais

- **Classes de Domínio com Comportamento**: As entidades de domínio contêm tanto os **dados** quanto a **lógica** relevante.
- **Encapsulamento**: A lógica de negócio está diretamente ligada aos dados, promovendo um encapsulamento efetivo.
- **Alta Coesão**: As regras de negócio permanecem próximas aos dados que manipulam.

## Exemplo Básico em C#

Vamos reescrever o exemplo do modelo anêmico para um **Modelo Rico**, onde a lógica de negócio agora é implementada diretamente nas entidades de domínio.

### Classe de Domínio (Rica)

Neste caso, as classes **Cliente** e **Pedido** contêm métodos com a lógica de negócios.

```csharp
public class Cliente
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }

    public Cliente(int id, string nome, string email)
    {
        Id = id;
        Nome = nome;
        SetEmail(email);
    }

    public void SetEmail(string novoEmail)
    {
        // Lógica para atualizar o e-mail
        if (!novoEmail.Contains("@"))
        {
            throw new ArgumentException("Email inválido.");
        }
        Email = novoEmail;
    }
}

public class Pedido
{
    public int Id { get; private set; }
    public DateTime DataPedido { get; private set; }
    public decimal ValorTotal { get; private set; }
    public int ClienteId { get; private set; }

    public Pedido(int id, DateTime dataPedido, decimal valorTotal, int clienteId)
    {
        Id = id;
        DataPedido = dataPedido;
        SetValorTotal(valorTotal);
        ClienteId = clienteId;
    }

    public void SetValorTotal(decimal valor)
    {
        // Lógica para validar o valor do pedido
        if (valor <= 0)
        {
            throw new ArgumentException("Valor do pedido deve ser positivo.");
        }
        ValorTotal = valor;
    }
}
```

## Vantagens do Modelo Rico

1. **Encapsulamento**: A lógica de negócios fica encapsulada nas próprias entidades de domínio, reduzindo a necessidade de classes de serviço.
2. **Alta Coesão**: As regras de negócio estão diretamente ligadas aos dados que manipulam, facilitando a manutenção e compreensão do código.
3. **Alinhamento com DDD (Domain-Driven Design)**: O modelo rico é mais alinhado com o DDD, onde as entidades de domínio são "ricas" em comportamento.

## Desvantagens do Modelo Rico

1. **Complexidade na Criação de Entidades**: Em cenários simples, pode adicionar complexidade desnecessária às classes de domínio.
2. **Responsabilidade Aumentada**: As entidades de domínio podem acabar com muitas responsabilidades, tornando-se difíceis de testar ou manter em projetos complexos.

## Quando Usar o Modelo Rico

O modelo rico é recomendado para sistemas onde **a lógica de negócios é complexa** ou onde é importante manter o **encapsulamento** e **coesão** das entidades de domínio. Em cenários onde o DDD é aplicado, o modelo rico é geralmente preferido.

---

Esta documentação descreve o Modelo Rico em C#, e como ele se diferencia do Modelo Anêmico, aplicando a lógica de negócios diretamente nas entidades de domínio.



# Modelo de Domínio Anêmico (Anemic Domain Model) - Conclusão

O modelo anêmico desrespeita os conceitos do paradigma da **POO - Programação Orientada a Objetos**.

Os objetos no paradigma da POO **possuem dados e comportamento**, e o objeto deve modelar a entidade em tempo real.

Ao **separar o comportamento**, não estamos seguindo o paradigma da POO, e, com comportamentos residindo em uma classe separada, será difícil **herdar**, aplicar **polimorfismo**, **abstração** e assim por diante.

Além disso, Modelos Anêmicos podem ter **estados inconsistentes** a qualquer momento.


As únicas opções justificáveis para usar um Modelo Anêmico seria usar para **DTOs – Data Transfer Objects**,
e para fazer um **CRUD (Create, Read, Update e Delete) básico**.
