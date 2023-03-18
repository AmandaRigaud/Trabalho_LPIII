# Linguagem de Programação III

### Docente

- Edson Mota da Cruz

### Equipe

- Amanda Rigaud
- Felipe Ribeiro
- Gabrielle Angelina

## Polimorfismo

Polimorfismo é um conceito importante da programação orientada a objetos, que
permite tratar objetos de diferentes classes de forma uniforme. Em outras palavras, o polimorfismo permite que uma mesma operação seja executada de formas diferentes, dependendo do tipo de objeto em questão.

Em C#, o polimorfismo pode ser implementado por meio de interfaces. Uma interface
define um conjunto de métodos que uma classe deve implementar. Por exemplo,
podemos ter uma interface chamada `IOperacoes` , que define um método **eval( )** .
Em seguida, podemos criar duas ou mais classes que implementam essa interface: `Soma`, `Subtracao`, `Divisao` e `Multiplicacao`. Cada uma dessas classes implementa o método **eval( )** de uma forma diferente.