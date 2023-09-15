using System;

class GeradorSenha
{
    // Objeto Random para gerar números aleatórios
    static Random random = new Random();

    // Função para gerar senha aleatória com base nas opções fornecidas
    static string GerarSenha(int comprimento, bool incluirLetrasMaiusculas, bool incluirLetrasMinusculas, bool incluirNumeros, bool incluirSimbolos)
    {
        // String que contém os caracteres possíveis para a senha
        string caracteres = "";
        if (incluirLetrasMaiusculas) caracteres += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        if (incluirLetrasMinusculas) caracteres += "abcdefghijklmnopqrstuvwxyz";
        if (incluirNumeros) caracteres += "0123456789";
        if (incluirSimbolos) caracteres += "!@#$%^&*()_+=-";

        // Array para armazenar a senha gerada
        char[] senha = new char[comprimento];
        for (int i = 0; i < comprimento; i++)
        {
            // Escolhe um caractere aleatório da string de caracteres
            senha[i] = caracteres[random.Next(caracteres.Length)];
        }
        // Converte o array de caracteres em uma string e retorna a senha gerada
        return new string(senha);
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite o comprimento da senha: ");
            int comprimento = int.Parse(Console.ReadLine());

            Console.Write("Incluir letras maiúsculas? (S/N): ");
            bool incluirLetrasMaiusculas = Console.ReadLine().ToUpper() == "S";

            Console.Write("Incluir letras minúsculas? (S/N): ");
            bool incluirLetrasMinusculas = Console.ReadLine().ToUpper() == "S";

            Console.Write("Incluir números? (S/N): ");
            bool incluirNumeros = Console.ReadLine().ToUpper() == "S";

            Console.Write("Incluir símbolos? (S/N): ");
            bool incluirSimbolos = Console.ReadLine().ToUpper() == "S";

            // Chama a função GerarSenha para criar a senha com base nas opções escolhidas
            string senha = GerarSenha(comprimento, incluirLetrasMaiusculas, incluirLetrasMinusculas, incluirNumeros, incluirSimbolos);
            Console.WriteLine($"Senha gerada: {senha}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Certifique-se de inserir valores corretos.");
        }
    }
}
