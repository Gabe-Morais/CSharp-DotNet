using System;
using System.Collections.Generic;

class ListaTarefas
{
    // Lista para armazenar as tarefas
    static List<string> tarefas = new List<string>();

    // Função para adicionar uma nova tarefa à lista
    static void AdicionarTarefa(string tarefa)
    {
        tarefas.Add(tarefa);
        Console.WriteLine("Tarefa adicionada com sucesso!");
    }

    // Função para marcar uma tarefa como concluída
    static void MarcarTarefaConcluida(int indice)
    {
        if (indice >= 0 && indice < tarefas.Count)
        {
            tarefas[indice] = "[CONCLUÍDA] " + tarefas[indice];
            Console.WriteLine("Tarefa marcada como concluída!");
        }
        else
        {
            Console.WriteLine("Índice inválido. Tarefa não encontrada.");
        }
    }

    // Função para remover uma tarefa da lista
    static void RemoverTarefa(int indice)
    {
        if (indice >= 0 && indice < tarefas.Count)
        {
            tarefas.RemoveAt(indice);
            Console.WriteLine("Tarefa removida com sucesso!");
        }
        else
        {
            Console.WriteLine("Índice inválido. Tarefa não encontrada.");
        }
    }

    static void Main(string[] args)
    {
        string opcao;
        do
        {
            Console.WriteLine("=== Lista de Tarefas ===");
            Console.WriteLine("1. Adicionar Tarefa");
            Console.WriteLine("2. Marcar Tarefa como Concluída");
            Console.WriteLine("3. Remover Tarefa");
            Console.WriteLine("4. Mostrar Tarefas");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a nova tarefa: ");
                    string novaTarefa = Console.ReadLine();
                    AdicionarTarefa(novaTarefa);
                    break;
                case "2":
                    Console.Write("Digite o índice da tarefa a marcar como concluída: ");
                    int indiceConcluir = int.Parse(Console.ReadLine());
                    MarcarTarefaConcluida(indiceConcluir);
                    break;
                case "3":
                    Console.Write("Digite o índice da tarefa a remover: ");
                    int indiceRemover = int.Parse(Console.ReadLine());
                    RemoverTarefa(indiceRemover);
                    break;
                case "4":
                    Console.WriteLine("=== Tarefas ===");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        Console.WriteLine($"{i}. {tarefas[i]}");
                    }
                    break;
                case "0":
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Escolha novamente.");
                    break;
            }

        } while (opcao != "0");
    }
}
