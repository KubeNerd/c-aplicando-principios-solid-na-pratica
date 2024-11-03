# Modificadores de Acesso em C#

Os modificadores de acesso em C# determinam o nível de visibilidade para classes, campos, métodos e propriedades. Abaixo estão os principais tipos de modificadores e uma explicação sobre cada um:

| Modificador          | Descrição |
|----------------------|-----------|
| **public**           | Não existe restrição de acesso. Qualquer classe ou método pode acessar membros marcados como `public`. |
| **private**          | O acesso é limitado aos membros da mesma classe. Este é o modificador padrão caso nenhum seja especificado. É útil para encapsular a lógica interna da classe, protegendo os dados e métodos que não devem ser acessados diretamente. |
| **protected**        | Permite acesso aos membros da mesma classe e também para classes derivadas. Esse modificador é ideal quando você deseja que subclasses tenham acesso a determinados membros sem permitir acesso externo. |
| **internal**         | O acesso é limitado às classes que estão dentro do mesmo assembly do projeto atual. Isso significa que outras classes externas ao assembly não poderão acessar membros internos. É útil para compartilhar dados apenas dentro do projeto. |
| **protected internal** | Combina as regras de `protected` e `internal`. Permite acesso dentro do assembly atual, assim como em tipos derivados, mesmo que estes estejam em outro assembly. Isso oferece um controle mais granular de visibilidade em projetos grandes. |
| **private protected** | O acesso é restrito à classe que o contém e aos tipos derivados que também estão no mesmo assembly. Esse modificador está disponível desde o C# 7.2 e proporciona uma camada de proteção adicional, útil para cenários onde é necessário um controle rígido de acesso entre heranças. |

---

### Considerações Críticas

- **Escolha Consciente dos Modificadores**: Usar `public` indiscriminadamente pode expor muitos detalhes da implementação, o que vai contra os princípios de encapsulamento. Em sistemas maiores, é importante proteger dados internos e métodos que não precisam ser acessíveis de fora.
- **Visibilidade em Projetos Modulares**: Em projetos que possuem múltiplos assemblies, `internal` e `protected internal` são úteis para restringir o acesso a elementos específicos dentro de um contexto. Eles permitem que a arquitetura do projeto seja mais modular e segura.
- **Evite o Uso de `private protected` Indiscriminado**: Embora ofereça um nível alto de proteção, `private protected` pode restringir excessivamente a flexibilidade de herança, tornando o código menos reutilizável.

Compreender e utilizar esses modificadores de forma eficiente é fundamental para criar uma arquitetura segura, modular e bem estruturada em C#.


### Mas, porque usar ?
 - COntrolar a visibilidade dos membros da classe (o nível de segurança de cada classe e membro da classe)

 - Para obter o "Encapsulamento" que é o processo de garantir que os dados "sensíveis" sejam ocultados aos usuários"


<br/>

```plaintext
                                Assemblies e Classes com `internal`
                    ┌───────────────────────────────────────────────┐
                    │                                               │
                    │                                               │
           ┌─────────────────┐                           ┌─────────────────┐
           │    Assembly1    │                           │    Assembly2    │
           └─────────────────┘                           └─────────────────┘
                    │                                               │
    ┌─────────────────────────┐                    ┌─────────────────────────┐
    │                         │                    │                         │
┌────────────┐          ┌────────────┐        ┌────────────┐          ┌────────────┐
│ internal   │          │ internal   │        │ internal   │          │ internal   │
│ Classe1    │          │ Classe2    │        │ Classe3    │          │            │
└────────────┘          └────────────┘        └────────────┘          └────────────┘
      │                     │                       │                      │
      │ Internal            │ Internal              │ Internal             │ Internal
      │ string nome         │ string nome           │ string nome          │ string nome
      │                     │                       │                      │
┌──────────────────────┐ ┌──────────────────────┐ ┌──────────────────────┐ ┌──────────────────────┐
│ Restringido a        │ │ Restringido a        │ │ Restringido a        │ │ Restringido a        │
│ `Assembly1`          │ │ `Assembly1`          │ │ `Assembly2`          │ │ `Assembly2`          │
└──────────────────────┘ └──────────────────────┘ └──────────────────────┘ └──────────────────────┘
