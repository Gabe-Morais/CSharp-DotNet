using System;

namespace ManipulacaoDeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manipulação de Strings");

            // Concatenação e interpolação de strings
            string nome = "João";
            string sobrenome = "Silva";
            string nomeCompleto = nome + " " + sobrenome;
            string saudacao = $"Olá, {nomeCompleto}!";

            Console.WriteLine(saudacao);

            // Manipulação de maiúsculas e minúsculas
            string texto = "Exemplo de TEXTO para Manipulação";
            string emMaiusculas = texto.ToUpper();
            string emMinusculas = texto.ToLower();

            Console.WriteLine("Texto original: " + texto);
            Console.WriteLine("Texto em maiúsculas: " + emMaiusculas);
            Console.WriteLine("Texto em minúsculas: " + emMinusculas);
        }
    }
}
