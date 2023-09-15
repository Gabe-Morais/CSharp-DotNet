using System;

namespace EstruturasDeControle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verificação de número positivo, negativo ou zero
            Console.WriteLine("---------------------------");
            Console.WriteLine("positivo, negativo ou zero");
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero.");
            }

            // Calculando a soma dos números de 1 até o número fornecido
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Calculando a soma dos números de 1 até o número fornecido");
            Console.Write("Digite um número para calcular a soma: ");
            int limite = Convert.ToInt32(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= limite; i++)
            {
                soma += i;
            }

            Console.WriteLine($"A soma dos números de 1 a {limite} é: {soma}");

            // Usando um array e loop foreach
            Console.WriteLine("----------------------------");
            Console.WriteLine("Array e Loop foreach");
            string[] cores = { "Vermelho", "Verde", "Azul", "Amarelo" };

            Console.WriteLine("Cores disponíveis:");

            foreach (string cor in cores)
            {
                Console.WriteLine(cor);
            }

            // Usando o switch para escolher uma opção
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Escolha uma opção (1 a 3):");
            Console.WriteLine("1 - Imprimir Olá");
            Console.WriteLine("2 - Imprimir Tchau");
            Console.WriteLine("3 - Imprimir Nada");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Olá!");
                    break;
                case 2:
                    Console.WriteLine("Tchau!");
                    break;
                case 3:
                    Console.WriteLine("Nada!");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
