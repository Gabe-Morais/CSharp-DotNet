# Introdução à Programação Orientada a Objetos (POO):
A Programação Orientada a Objetos (POO) é um paradigma de programação que se baseia em objetos para modelar e organizar o código. Os objetos são instâncias de classes que representam entidades do mundo real. POO usa conceitos como encapsulamento, herança e polimorfismo para facilitar o desenvolvimento de software.

## Classes e Objetos em C#:
Em C#, uma classe é um modelo ou plano para criar objetos. Por exemplo, podemos criar uma classe chamada "Carro" que define as características e comportamentos de um carro. Um objeto seria uma instância dessa classe, como "MeuCarro".

```
// Definindo uma classe chamada "Carro"
class Carro
{
    // Campos públicos para armazenar informações sobre o carro
    public string Marca;
    public string Modelo;
    
    // Método público para ligar o carro
    public void Ligar()
    {
        Console.WriteLine("O carro está ligado.");
    }
}

// Criando um objeto "MeuCarro" a partir da classe "Carro"
Carro MeuCarro = new Carro();
MeuCarro.Marca = "Toyota";
MeuCarro.Modelo = "Corolla";
MeuCarro.Ligar();
```

## Encapsulamento, Herança e Polimorfismo:

- Encapsulamento: É o conceito de ocultar os detalhes de implementação de uma classe e fornecer acesso controlado aos seus membros. Isso é feito usando modificadores de acesso como public, private e protected.
- Herança: Permite que uma classe herde características e comportamentos de outra classe. Por exemplo, uma classe "CarroEsportivo" pode herdar da classe "Carro".
- Polimorfismo: É a capacidade de objetos de diferentes classes responderem de maneira semelhante a mensagens ou chamadas de método. Isso pode ser alcançado usando herança e interfaces.


## Criando Classes e Objetos em C#:
Em C#, você cria classes definindo seus membros, como métodos e campos, e, em seguida, cria objetos a partir dessas classes. Aqui está um exemplo de uma classe "Pessoa" e a criação de um objeto "João" a partir dela:

```
class Pessoa
{
    public string Nome;
    public int Idade;
}

Pessoa Joao = new Pessoa();
Joao.Nome = "João";
Joao.Idade = 30;
```

## Acessando Membros da Classe:
Os membros da classe podem ser acessados usando a notação de ponto. Por exemplo:

```
Pessoa Carlos = new Pessoa();
Carlos.Nome = "Carlos";
int idadeCarlos = Carlos.Idade;
```

## Métodos e Propriedades:
Métodos são funções definidas em uma classe que podem executar ações. Propriedades são membros da classe que permitem acesso controlado a campos privados. Por exemplo, podemos adicionar um método "Andar" e uma propriedade "Altura" à classe "Pessoa".

```
// Definindo uma classe chamada "Pessoa"
class Pessoa
{
    // Campos públicos para armazenar informações sobre a pessoa
    public string Nome;
    public int Idade;

    // Propriedade auto-implementada para a altura
    public double Altura { get; set; }

    // Método público para fazer a pessoa andar
    public void Andar()
    {
        Console.WriteLine(Nome + " está andando.");
    }
}

// Criando um objeto "Maria" a partir da classe "Pessoa"
Pessoa Maria = new Pessoa();
Maria.Nome = "Maria";
Maria.Idade = 25;
Maria.Altura = 1.65;
Maria.Andar();

```

## Construtores e Destrutores:
Construtores são métodos especiais usados para inicializar objetos quando são criados. Destrutores são usados para liberar recursos quando um objeto é destruído. Exemplo de um construtor:

```
class Pessoa
{
    public string Nome;
    public int Idade;

    // Construtor personalizado que recebe nome e idade como parâmetros
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

// Criando um objeto "Joana" com o construtor personalizado
Pessoa Joana = new Pessoa("Joana", 40);
```

## Campos e Propriedades Auto-implementadas:
Campos são variáveis de instância em uma classe. Propriedades auto-implementadas são uma maneira mais concisa de criar propriedades. Aqui está um exemplo de uma propriedade auto-implementada:

```
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

Pessoa Pedro = new Pessoa();
Pedro.Nome = "Pedro";
Pedro.Idade = 35;
```

## Sobrecarga de Métodos e Construtores:
Você pode ter vários métodos ou construtores com o mesmo nome, mas com diferentes parâmetros. Isso é chamado de sobrecarga. Por exemplo:

```
// Definindo uma classe chamada "Calculadora"
class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }
    public double Somar(double a, double b)
    {
        return a + b;
    }
}

```
