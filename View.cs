using PostDataClass;

internal class View
{
    public delegate void MenuChoiceEventHandler(string choice);

    // Evento que será acionado quando o usuário fizer uma escolha no menu
    public event MenuChoiceEventHandler MenuChoiceMade;

    public void ShowMainMenu()
    {
        Console.WriteLine("Escolha uma Opção:");
        Console.WriteLine("1. Mostrar Post´s Mais Bem Sucedidos com Base na Quantidade de Views");
        Console.WriteLine("2. Mostrar Post´s Menos Bem Sucessidos com Base na Quantidade de Views");
        Console.WriteLine("3. Mostrar Post´s com Mais Reações");
        Console.WriteLine("4. Sair");
        Console.WriteLine("Digite a opção desejada: ");

        string escolha = Console.ReadLine();
        // Acionar o evento MenuChoiceMade com a escolha do usuário
        MenuChoiceMade?.Invoke(escolha);
    }


    public void ListarPostsMaisBemSucedidos(List<PostData> posts)
    {
        Console.WriteLine("Listando os posts mais bem sucedidos por visualizações:");
        // var postsOrdenados = posts.OrderByDescending(p => p.ViewCount); // Ordena os posts por número de visualizações
        DisplayData(posts);
    }

    public void ListarPostsMenosBemSucedidos(List<PostData> posts)
    {
        Console.WriteLine("Listando os posts menos bem sucedidos por visualizações:");
        //var postsOrdenados = posts.OrderBy(p => p.ViewCount); // Ordena os posts por número de visualizações em ordem crescente
        DisplayData(posts);
    }
    public void ListarPostsComMaisReacoes(List<PostData> posts)
    {
        Console.WriteLine("Listando os posts com mais reações:");
        // var postsOrdenados = posts.OrderByDescending(p => p.ReactionCount); // Ordena os posts por número de reações em ordem decrescente
        DisplayData(posts);
    }


    private void DisplayData(List<PostData> posts)
    {
        foreach (var post in posts)
        {
            Console.WriteLine($"ID: {post.Id}");
            Console.WriteLine($"AppId: {post.AppId}");
            Console.WriteLine($"Descrição: {post.Description}");
            Console.WriteLine($"Visualizações: {post.ViewCount}");
            Console.WriteLine($"Likes: {post.LikeCount}");
            Console.WriteLine($"Reações: {post.ReactionCount}");
            Console.WriteLine($"Data Criação: {post.CreationDate}");
            Console.WriteLine();
        }
    }
}