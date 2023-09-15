using System;

namespace VariaveisTiposDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Este é um programa simples para demonstrar variáveis e tipos de dados em C#

            // Variáveis para armazenar informações
            int idade = 25;                  // Usamos o tipo int para números inteiros
            double altura = 1.75;            // Usamos o tipo double para números decimais
            string nome = "João";            // Usamos o tipo string para armazenar texto
            bool ehEstudante = true;          // Usamos o tipo bool para valores verdadeiro/falso

            // Exibindo informações na tela
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade + " anos");
            Console.WriteLine("Altura: " + altura + " metros");
            Console.WriteLine("É estudante? " + ehEstudante);
        }
    }
}
