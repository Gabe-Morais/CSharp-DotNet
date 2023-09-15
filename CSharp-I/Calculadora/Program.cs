using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Operações e Média");

            // Solicita ao usuário para inserir três números
            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            double numero3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------");

            // Realiza as operações matemáticas
            double soma = numero1 + numero2 + numero3;
            double subtracao = numero1 - numero2 - numero3;
            double multiplicacao = numero1 * numero2 * numero3;

            // Verifica se há divisão por zero
            double divisao = 0;
            if (numero2 != 0 && numero3 != 0)
            {
                divisao = numero1 / (numero2 * numero3);
            }

            // Calcula a média dos números
            double media = soma / 3;

            // Exibe os resultados
            Console.WriteLine("Resultados:");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Subtração: {subtracao}");
            Console.WriteLine($"Multiplicação: {multiplicacao}");
            Console.WriteLine($"Divisão: {divisao:F2}");
            Console.WriteLine($"Média: {media:F2}");
        }
    }
}
