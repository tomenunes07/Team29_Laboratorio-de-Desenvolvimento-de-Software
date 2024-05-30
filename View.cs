using System;
using PostInfoClass;

internal class View
{
    public delegate void MenuChoiceEventHandler(string choice);

    // Evento que será acionado quando o utilizador fizer uma escolha no menu
    public event MenuChoiceEventHandler MenuChoiceMade;

    public void ShowMainMenu()
    {
        Console.Clear();

        Console.WriteLine("Escolha uma Opção:");
        Console.WriteLine("1. Mostrar Post´s Mais Bem Sucedidos com Base na Quantidade de Views");
        Console.WriteLine("2. Mostrar Post´s Menos Bem Sucedidos com Base na Quantidade de Views");
        Console.WriteLine("3. Mostrar Post´s com Mais Reações");
        Console.WriteLine("4. Sair");
        Console.WriteLine("Digite a opção desejada: ");

        string escolha = Console.ReadLine();
        Console.Clear();
        // Acionar o evento MenuChoiceMade com a escolha do usuário
        MenuChoiceMade?.Invoke(escolha);
    }


    public void ListarPostsMaisBemSucedidos(List<PostInfo> posts)
    {
        Console.WriteLine("Listando os posts mais bem sucedidos por visualizações:");
        Console.WriteLine();
        DisplayData(posts);
    }

    public void ListarPostsMenosBemSucedidos(List<PostInfo> posts)
    {
        Console.WriteLine("Listando os posts menos bem sucedidos por visualizações:");
        DisplayData(posts);
    }

    public void ListarPostsComMaisReacoes(List<PostInfo> posts)
    {
        Console.WriteLine("Listando os posts com mais reações:");
        DisplayData(posts);
    }

    public void DisplayData(List<PostInfo> posts)
    {
        int i = 1;
        foreach (var post in posts)
        {
            Console.WriteLine($"# {i}");
            Console.WriteLine($"Descrição: {post.Description}");
            Console.WriteLine($"Visualizações: {post.ViewCount}");
            Console.WriteLine($"Likes: {post.LikeCount}");
            Console.WriteLine($"Reações: {post.ReactionCount}");
            Console.WriteLine($"Data Criação: {post.CreationDate}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
            i++;
        }
        Console.WriteLine();
        Console.WriteLine("Prima qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
}
