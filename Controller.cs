using PostInfoClass;

internal class Controller
{
    private Model model;
    private View view;
    private List<PostInfo> postInfoList;

    public Controller()
    {
        this.model = new Model();
        this.view = new View(); 
        this.postInfoList = new List<PostInfo>();

        // Inscrever-se no evento MenuChoiceMade da View
        this.view.MenuChoiceMade += HandleMenuChoice;
    }
    private async Task InitializeAsync()
    {
        postInfoList = await model.GetPostsAsync();
    }

    public async Task StartController()
    {
        await InitializeAsync();
        view.ShowMainMenu();
    }

    private void HandleMenuChoice(string choice)
    {
        switch (choice)
        {
            case "1":
                PostsMaisBemSucedidos();
                break;
            case "2":
                PostsMenosBemSucedidos();
                break;
            case "3":
                PostsComMaisReacoes();
                break;
            case "4":
                Environment.Exit(0);
                break;
            default:
               Console.WriteLine("Opção inválida. Tente novamente.");
               Console.WriteLine("Prima qualquer tecla para voltar ao menu...");
               Console.ReadKey();
               break;
        }

        view.ShowMainMenu();
    }

    private void PostsMaisBemSucedidos()
    {
        var postsOrdenados = postInfoList.OrderByDescending(p => p.ViewCount).ToList();
        var top10Posts = postsOrdenados.Take(10).ToList();
        view.ListarPostsMaisBemSucedidos(top10Posts);
    }

    private void PostsMenosBemSucedidos()
    {
        var postsOrdenados = postInfoList.OrderBy(p => p.ViewCount).ToList();
        var top10Posts = postsOrdenados.Take(10).ToList();
        view.ListarPostsMenosBemSucedidos(top10Posts);
    }

    private void PostsComMaisReacoes()
    {
        var postsOrdenados = postInfoList.OrderByDescending(p => p.ReactionCount).ToList();
        var top10Posts = postsOrdenados.Take(10).ToList();
        view.ListarPostsComMaisReacoes(top10Posts);
    }
}