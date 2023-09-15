using System;

namespace ImparPar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine(numero + " é um número par.");
            }
            else
            {
                Console.WriteLine(numero + " é um número ímpar.");
            }
        }
    }
}
