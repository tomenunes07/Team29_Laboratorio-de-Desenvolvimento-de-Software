class View
{
    public void ListarPostsMaisBemSucedidos(List<PostInfo> posts)
    {
        Console.WriteLine("Listando os posts mais bem sucedidos por visualizações:");
        var postsOrdenados = posts.OrderByDescending(p => p.ViewCount); // Ordena os posts por número de visualizações
        foreach (var post in postsOrdenados)
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

        public void ListarPostsMenosBemSucedidos(List<PostInfo> posts)
        {
            Console.WriteLine("Listando os posts menos bem sucedidos por visualizações:");
            var postsOrdenados = posts.OrderBy(p => p.ViewCount); // Ordena os posts por número de visualizações em ordem crescente
            foreach (var post in postsOrdenados)
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
        public void ListarPostsComMaisReacoes(List<PostInfo> posts)
        {
            Console.WriteLine("Listando os posts com mais reações:");
            var postsOrdenados = posts.OrderByDescending(p => p.ReactionCount); // Ordena os posts por número de reações em ordem decrescente
            foreach (var post in postsOrdenados)
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
}