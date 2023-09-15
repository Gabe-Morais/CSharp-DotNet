using System;

class JogoAdivinhacao
{
    static void Main(string[] args)
    {
        int numeroAleatorio = new Random().Next(1, 101);
        int tentativas = 0;
        bool acertou = false;

        Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

        do
        {
            Console.Write("Digite um número: ");
            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out int palpite))
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro.");
                continue;
            }

            tentativas++;

            if (palpite < numeroAleatorio)
            {
                Console.WriteLine("O número é maior.");
            }
            else if (palpite > numeroAleatorio)
            {
                Console.WriteLine("O número é menor.");
            }
            else
            {
                acertou = true;
                Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativas.");
            }

        } while (!acertou);

        Console.WriteLine("Fim do jogo.");
    }
}
