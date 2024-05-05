using System;

namespace LabDev
{
    class View
    {

        private void DisplayData(List<PostInfo> posts)
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
        public void ListarPostsMaisBemSucedidos(List<PostInfo> posts)
        {
            {
                Console.WriteLine("Listando os posts mais bem sucedidos por visualizações:");
                DisplayData(posts);
            }

            public void ListarPostsMenosBemSucedidos(List<PostInfo> posts)
            {
                {
                    Console.WriteLine("Listando os posts menos bem sucedidos por visualizações:");
                    DisplayData(posts);
                }
            }
            public void ListarPostsComMaisReacoes(List<PostInfo> posts)
            {
                {
                    Console.WriteLine("Listando os posts com mais reações:");
                    DisplayData(posts);
                }
            }
        }
    }
}