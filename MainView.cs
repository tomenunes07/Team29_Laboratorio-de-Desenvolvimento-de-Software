using System;

namespace LabDev

class MainView()
{
    static void Main(string[] args) { 
    {
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("Escolha uma Opção:");
            Console.WriteLine("1. Mostrar Post´s Mais Bem Sucedidos com Base na Quantidade de Views");
            Console.WriteLine("2. Mostrar Post´s Menos Bem Sucessidos com Base na Quantidade de Views");
            Console.WriteLine("3. Mostrar Post´s com Mais Reações");
            Console.WriteLine("4. Sair");

            Console.WriteLine("Digite a opção desejada: ");
            string escolha = Console.ReadLine();
            switch (escolha)
            {
                case "1":
                    Console.WriteLine("Mostrando Post´s Mais Bem Sucedidos com Base na Quantidade de Views");
                    //função Post´s Mais Bem Sucedidos com Base na Quantidade de Views
                    Console.WriteLine("Pressione ESC para voltar ao Menu Principal....");
                    while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
                    Console.Clear(); //Limpar a consola
                    break;
                case "2":
                    Console.WriteLine("Mostrando Post´s Menos Bem Sucedidos com Base na Quantidade de Views");
                    //função Post´s Menos Bem Sucessidos com Base na Quantidade de Views
                    Console.WriteLine("Pressione ESC para voltar ao Menu Principal....");
                    while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
                    Console.Clear(); //Limpar a consola
                    break;
                case "3":
                    //função Mostrar Post´s com Mais Reações
                    Console.WriteLine("Pressione ESC para voltar ao Menu Principal....");
                    while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
                    Console.Clear(); //Limpar a consola
                    break;
                case "4":
                    Console.WriteLine("Saindo...");
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opçcão Inexistente!! Tente Novamente");
                    break;
            }
            Console.WriteLine(); // Adiciona uma linha em branco para melhor legibilidade

        }
    }
}