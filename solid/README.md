# Code Smells e Clean Code

## **O que é Code Smell?**
**Code Smell** é um termo que descreve sintomas ou características negativas em um código que indicam **problemas de design ou manutenção**. Ele não impede o código de funcionar, mas **sinaliza que algo pode estar errado**, dificultando a legibilidade, evolução e manutenção.

### **Exemplos Comuns de Code Smells**
1. **Métodos muito longos:** Difícil de entender e testar.
2. **Nomes confusos:** Classes, métodos ou variáveis com nomes que não refletem claramente sua função.
3. **Dependências rígidas:** Classes com alto acoplamento.
4. **Duplicação de código:** Trechos repetidos que violam o princípio DRY (*Don't Repeat Yourself*).
5. **Comentários excessivos:** Indicativo de que o código não é autoexplicativo.

---

## **Code Smells vs Clean Code**

**Clean Code** é um conjunto de princípios e boas práticas que ajuda a escrever códigos legíveis, simples e fáceis de manter. É o oposto de **Code Smells**, pois evita a introdução de sintomas negativos.

### **Comparação entre Code Smells e Clean Code**

| **Aspecto**               | **Code Smells**                                                                                   | **Clean Code**                                                                                            |
|---------------------------|---------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------|
| **Legibilidade**          | Difícil de entender; nomes genéricos ou confusos.                                                | Legível e autoexplicativo; bons nomes para classes, métodos e variáveis.                                |
| **Complexidade**          | Métodos e classes gigantes com várias responsabilidades.                                         | Código simples, focado em cumprir apenas uma responsabilidade (princípio SRP).                          |
| **Acoplamento**           | Classes ou métodos muito dependentes uns dos outros, causando fragilidade.                       | Baixo acoplamento, facilitando alterações isoladas sem impactar o sistema.                              |
| **Duplicação de Código**  | Mesma lógica repetida em diferentes partes do sistema.                                           | Código reutilizável, aderente ao princípio DRY (*Don't Repeat Yourself*).                               |
| **Documentação**          | Requer muitos comentários para explicar o que o código faz, pois ele não é autoexplicativo.      | Comentários mínimos, apenas para explicar "o porquê" (o "como" deve estar claro pelo código).           |
| **Testabilidade**         | Difícil de testar devido à dependência entre classes ou métodos complexos.                       | Código modular, com dependências injetadas e classes fáceis de isolar para testes.                      |

---

## **Revisão do Clean Code (Principais Pilares)**

### 1. **Nomes Claros e Simples**
- Métodos, variáveis e classes devem ter nomes que expliquem sua finalidade.
- **Exemplo (C#):**

```csharp
// Code Smell
int x = Calculate(100); // O que é "x"?

// Clean Code
int orderTotal = CalculateOrderTotal(100);
```

# SOLID

**SOLID** são cinco princípios da programação orientada a objetos que facilitam no desenvolvimento de softwares, tornando-os fáceis de manter, testar e estender.

Esses princípios podem ser aplicados a qualquer linguagem de POO e são os fundamentos de praticamente todos os padrões e princípios que nos levam a um código limpo.

S - SRP
 * Single Responsability. O princípio da responsabilidade unica. Cada classe deve ter um, e somente um motivo para mudar.

O - OCP
 * Open / Close Principle. Princípio do Aberto/Fechado. Só é necessário/possível estender o comportamente de uma classe.

L - LSP
 * Liskov Substituition Principle. Princípio da substituição de Liskov. As classes derivadas devem ser substituíveis por classes base.

I - ISP
 * Interface Segregation Princpal. Princípio da segregação de interfaces. Muitas interfaces específicas são melhores do que uma interface única geral.

D - DIP
 * Dependency Inversion Principle. Princípio da inversão de dependência. Depende de abstração, e não de implementação.


# DRY - Don't Repeat Yourself

## **O que é DRY?**
**DRY** é uma sigla para **"Don't Repeat Yourself"** (ou "Não se repita"), um dos princípios fundamentais do desenvolvimento de software. Ele prega que **a duplicação de lógica, código ou informação deve ser evitada ao máximo**.

O objetivo principal do DRY é manter o código **modular, fácil de manter e consistente**, centralizando responsabilidades em um único lugar.


O principio DRY tem a ver a dúplicação da lógica do conhecimento e não simplesmente dúplicação de código.

Possuir a lógica do conhecimento em um único lugar para facilitar a manutenção.

- Não copie e cole partes de funcionalidades no código do seu projeto
- Não coloque a mesma repsonsabilidade em camadas diferentes da aplicação
- Não use nomes diferentes que representem a mesma lógica ou conhecimento.
- Evite código ambíguo com conhecimento duplicado em partes do projeto

Devemos sempre:
    - Encapsular funcionalidades em métodos
    - Usar boas práticas da programação POO
    - Aplicar os princípios SOLID e outros princípios (KISS, YAGNI, etc)
    - Usar padrões de projeto

---

## **Por que o DRY é importante?**
1. **Reduz manutenção:** Alterações precisam ser feitas em apenas um lugar.
2. **Melhora a legibilidade:** O código se torna mais limpo e fácil de entender.
3. **Evita erros:** Reduz a chance de inconsistências e bugs ao eliminar duplicações.
4. **Promove reusabilidade:** Componentes ou funções podem ser usados em várias partes do sistema.

---

## **Exemplo de Violação do DRY**
Aqui está um exemplo onde a lógica do cálculo de imposto é repetida em várias partes do código:

### Código com duplicação:

```csharp
// Cálculo do imposto em uma parte do sistema
decimal CalcularImpostoSalario(decimal salario)
{
    return salario * 0.15m; // 15% de imposto
}

// Cálculo do imposto em outra parte do sistema
decimal impostoProduto = precoProduto * 0.15m; // Mesma lógica duplicada

