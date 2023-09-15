using System;

namespace NotasTurma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Gerenciamento de Notas");

            // Solicita ao usuário o número de alunos na turma
            Console.Write("Digite o número de alunos na turma: ");
            int numAlunos = Convert.ToInt32(Console.ReadLine());

            // Arrays para armazenar nomes, notas 1 e notas 2 dos alunos
            string[] nomes = new string[numAlunos];
            double[] notas1 = new double[numAlunos];
            double[] notas2 = new double[numAlunos];

            // Loop para coletar informações de cada aluno
            for (int i = 0; i < numAlunos; i++)
            {
                Console.WriteLine($"Aluno {i + 1}:");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();

                Console.Write("Nota 1: ");
                notas1[i] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nota 2: ");
                notas2[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("Relatório de Notas:");

            // Loop para exibir relatório de notas de cada aluno
            for (int i = 0; i < numAlunos; i++)
            {
                double media = (notas1[i] + notas2[i]) / 2;
                string situacao = media >= 7.0 ? "Aprovado" : "Reprovado";

                Console.WriteLine($"Aluno: {nomes[i]}");
                Console.WriteLine($"Nota 1: {notas1[i]}");
                Console.WriteLine($"Nota 2: {notas2[i]}");
                Console.WriteLine($"Média: {media:F2}");
                Console.WriteLine($"Situação: {situacao}");
                Console.WriteLine();
            }
        }
    }
}
