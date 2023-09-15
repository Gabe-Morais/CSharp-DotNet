using System;

class ConversorUnidades
{
    // Função para converter temperatura de Celsius para Fahrenheit
    static double CelsiusParaFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Função para converter comprimento de metros para polegadas
    static double MetrosParaPolegadas(double metros)
    {
        return metros * 39.37;
    }

    // Função para converter peso de quilogramas para libras
    static double QuilosParaLibras(double quilos)
    {
        return quilos * 2.20462;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            Console.WriteLine($"Temperatura em Fahrenheit: {CelsiusParaFahrenheit(celsius):F2}");

            Console.Write("Digite o comprimento em metros: ");
            double metros = double.Parse(Console.ReadLine());

            Console.WriteLine($"Comprimento em Polegadas: {MetrosParaPolegadas(metros):F2}");

            Console.Write("Digite o peso em quilogramas: ");
            double quilos = double.Parse(Console.ReadLine());

            Console.WriteLine($"Peso em Libras: {QuilosParaLibras(quilos):F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Certifique-se de inserir números válidos.");
        }
    }
}
