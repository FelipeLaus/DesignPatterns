# Design Patterns em C#

Projeto de estudos com objetivo de implementar todos os Design Patterns clássicos do **Gang of Four (GoF)** utilizando C# e .NET 10.

## 📚 Sobre o Projeto

Este repositório contém implementações práticas dos 23 Design Patterns do livro "Design Patterns: Elements of Reusable Object-Oriented Software". Cada pattern está organizado em seu próprio projeto, com exemplos de uso e comentários explicativos.

## 🎯 Objetivo

Aprofundar o conhecimento em Design Patterns através da prática, implementando cada um dos padrões com exemplos reais e aplicáveis.

## 📂 Estrutura do Projeto

Cada Design Pattern está implementado em um projeto separado dentro da solução:

```
DesignPatterns/
├── Command/
├── ChainOfResponsability/
├── State/
├── Strategy/
├── TemplateMethod/
├── Observer/
└── README.md
```

## ✅ Patterns Implementados

### Padrões Comportamentais (Behavioral)

- [x] **Command** - Encapsula uma requisição como um objeto
- [x] **Chain of Responsibility** - Passa requisições ao longo de uma cadeia de handlers
- [x] **State** - Permite que um objeto altere seu comportamento quando seu estado interno muda
- [x] **Strategy** - Define uma família de algoritmos e os torna intercambiáveis
- [x] **Template Method** - Define o esqueleto de um algoritmo, delegando alguns passos às subclasses

### Padrões Criacionais (Creational)

- [ ] **Abstract Factory** - Cria famílias de objetos relacionados
- [ ] **Builder** - Constrói objetos complexos passo a passo
- [ ] **Factory Method** - Define uma interface para criar objetos
- [ ] **Prototype** - Cria novos objetos clonando instâncias existentes
- [ ] **Singleton** - Garante uma única instância de uma classe

### Padrões Estruturais (Structural)

- [ ] **Adapter** - Permite que interfaces incompatíveis trabalhem juntas
- [ ] **Bridge** - Separa uma abstração de sua implementação
- [ ] **Composite** - Compõe objetos em estruturas de árvore
- [ ] **Decorator** - Adiciona responsabilidades a objetos dinamicamente
- [ ] **Facade** - Fornece uma interface simplificada para um subsistema
- [ ] **Flyweight** - Compartilha objetos para suportar grandes quantidades
- [ ] **Proxy** - Fornece um substituto para controlar o acesso a um objeto

### Outros Padrões Comportamentais

- [ ] **Interpreter** - Define uma representação gramatical para uma linguagem
- [ ] **Iterator** - Acessa elementos sequencialmente sem expor a estrutura
- [ ] **Mediator** - Define um objeto que encapsula a interação entre objetos
- [ ] **Memento** - Captura e restaura o estado interno de um objeto
- [x] **Observer** - Define dependência um-para-muitos entre objetos
- [ ] **Visitor** - Define uma nova operação sem alterar as classes dos elementos

## 🚀 Como Executar

Cada projeto pode ser executado individualmente:

```bash
# Exemplo: Executando o projeto Command
cd Command
dotnet run
```

Ou através do Visual Studio, selecionando o projeto desejado como projeto de inicialização.

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C# 14.0
- **Framework:** .NET 10
- **IDE:** Visual Studio 2026 Community

## 📖 Recursos de Estudo

- [Design Patterns - Refactoring.Guru](https://refactoring.guru/design-patterns)
- [Design Patterns: Elements of Reusable Object-Oriented Software](https://www.amazon.com/Design-Patterns-Elements-Reusable-Object-Oriented/dp/0201633612)
- [C# Design Patterns - Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/standard/design-patterns/)

## 📝 Licença

Este projeto é apenas para fins educacionais.

## 👤 Autor

**Felipe Laus**

- GitHub: [@FelipeLaus](https://github.com/FelipeLaus)

---

⭐ Se este projeto te ajudou nos estudos, considere dar uma estrela!
