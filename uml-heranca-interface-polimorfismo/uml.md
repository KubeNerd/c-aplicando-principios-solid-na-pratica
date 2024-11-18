
# UML - Unified Modeling Language

A **UML** (Unified Modeling Language) é uma linguagem de modelagem visual utilizada para **especificar, visualizar, construir** e **documentar** componentes de sistemas de software. Ela fornece uma maneira padronizada de desenhar diagramas que representam a estrutura, o comportamento e as interações dentro de um sistema.

## Propósito da UML

A UML é amplamente usada no desenvolvimento de software para:
- **Especificar** os requisitos e as funcionalidades de um sistema.
- **Visualizar** o design do sistema e como suas partes se relacionam.
- **Construir** a arquitetura do software com uma representação clara e organizada.
- **Documentar** a estrutura e o comportamento do sistema, facilitando a comunicação entre desenvolvedores, stakeholders e equipes.

## Diagramas da UML

A UML fornece vários tipos de diagramas que representam diferentes aspectos de um sistema. Entre os mais comuns estão:

1. **Diagrama de Classes**: Representa a estrutura de um sistema, mostrando as classes, atributos, métodos e os relacionamentos entre elas.
2. **Diagrama de Casos de Uso**: Descreve as interações entre atores externos e o sistema para atender a um objetivo específico.
3. **Diagrama de Sequência**: Mostra a sequência de interações entre objetos ao longo do tempo para realizar uma operação.
4. **Diagrama de Atividades**: Representa o fluxo de atividades e decisões em um processo ou operação.

Neste curso, focaremos no **Diagrama de Classes** da UML para representar classes e seus relacionamentos.

## Diagrama de Classes

O **Diagrama de Classes** é um dos mais importantes diagramas da UML, pois representa a estrutura estática do sistema. Ele inclui:

- **Classes**: Entidades que compõem o sistema, com seus atributos (dados) e métodos (operações).
- **Associações**: Relacionamentos entre classes, como herança, composição e agregação.
- **Modificadores de Acesso**: Indicam a visibilidade dos membros da classe (público, privado, protegido).
  
Exemplo de representação de uma classe em UML:

```
+--------------------+
|      Carro         |
+--------------------+
| - marca: string    |
| - ano: int         |
+--------------------+
| + LigarMotor(): void |
| + Desligar(): void |
+--------------------+
```

### Principais Relacionamentos no Diagrama de Classes

- **Herança**: Representada por uma linha com um triângulo apontando para a classe base, indica que uma classe deriva de outra.
- **Composição**: Representada por um losango preenchido, indica uma relação de "parte-todo" onde a parte não pode existir sem o todo.
- **Agregação**: Representada por um losango vazio, indica uma relação de "parte-todo" onde a parte pode existir independentemente do todo.
- **Associação**: Representada por uma linha simples, indica uma relação entre duas classes sem uma hierarquia específica.

### Vantagens do Diagrama de Classes UML

- Facilita a **visualização da estrutura** do sistema.
- Ajuda a **identificar responsabilidades** das classes e seus relacionamentos.
- Facilita a comunicação entre **desenvolvedores** e **stakeholders**.
- Documenta a arquitetura do sistema, ajudando na **manutenção e evolução** do software.

---

O uso da UML, e especialmente do Diagrama de Classes, é fundamental para projetar sistemas robustos e organizados, facilitando o entendimento e o desenvolvimento colaborativo.



---

## Notação UML - Diagrama de Classes

Na UML, a representação de uma classe usa um retângulo dividido em três partes: nome da classe, atributos e métodos.

### Classe: Pessoa

## Notação UML - Diagrama de Classes

Na UML, a representação de uma classe usa um retângulo dividido em três partes: **nome da classe**, **atributos da classe** e **métodos da classe**.

```text
+-----------------------------+          Nome da classe
|          Pessoa             |          +----------------+
+-----------------------------+          | "Pessoa"       |
| dataNascimento : DateTime   |  <----   Atributos da classe
| Nome           : string     |          +----------------+
| Idade          : int        |
| Sexo           : string     |
+-----------------------------+          Métodos da classe
| IdentificarPessoa()         |  <----   +----------------+
| Pessoa()                    |          | "Métodos"      |
+-----------------------------+

Nome da Classe: Pessoa

Representa o título da classe no diagrama.

Atributos da Classe:
dataNascimento : DateTime

Nome : string

Idade : int

Sexo : string

Métodos da Classe:

IdentificarPessoa()

Pessoa()
