using System;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Construtor personalizado
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // Método para exibir informações sobre a pessoa
    public void Apresentar()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}

class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    // Construtor padrão
    public Carro()
    {
        Marca = "Desconhecida"; // Valores padrão para a marca e o modelo
        Modelo = "Desconhecido";// Caso não informe nada no "Carro()", ex Carro("Toyota", "Corolla")
    }

    // Construtor personalizado
    public Carro(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    // Método para exibir informações sobre o carro
    public virtual void Apresentar()
    {
        Console.WriteLine($"Carro: {Marca} {Modelo}");
    }
}

class CarroEsportivo : Carro
{
    public bool TemTurbo { get; set; }

    // Construtor personalizado para carro esportivo
    public CarroEsportivo(string marca, string modelo, bool temTurbo)
        : base(marca, modelo)
    {
        TemTurbo = temTurbo;
    }

    // Sobrescreva o método Apresentar para incluir informações sobre o turbo
    public override void Apresentar()
    {
        string turboInfo = TemTurbo ? "com turbo" : "sem turbo";
        Console.WriteLine($"Carro Esportivo: {Marca} {Modelo}, {turboInfo}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criar uma pessoa
        Pessoa pessoa = new Pessoa("Gabriel", 21);
        pessoa.Apresentar();

        // Criar carros
        Carro meuCarro = new Carro("Mitsubishi", "Lancer");
        CarroEsportivo meuCarroEsportivo = new CarroEsportivo("Ferrari", "F40", true);

        meuCarro.Apresentar();
        meuCarroEsportivo.Apresentar();
    }
}
