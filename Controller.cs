using PostInfoClass;
using System;
internal class Controller
{
    private Model model;
    private View view;
    private List<PostInfo> postInfoList;
    private ModelLog log;

    public Controller(Model model, View view, List<PostInfo> postInfoList)
    {
        this.model = model;
        this.view = view;
        this.postInfoList = postInfoList;

        // Inscrever-se no evento MenuChoiceMade da View
        this.view.MenuChoiceMade += HandleMenuChoice;
    }
    private async Task InitializeAsync()
    {
        postInfoList = await model.GetPostsAsync();
    }

    public async Task StartController()
    {
        try
        {
            await InitializeAsync();
            view.ShowMainMenu();
        }
        catch (Exception ex)
        {
            HandleError(ex);
        }
    }

    private void HandleMenuChoice(string choice)
    {
        try
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
        }
        catch (Exception ex)
        {
            HandleError(ex);
        }
        finally
        {
            view.ShowMainMenu();
        }
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

    private void HandleError(Exception ex)
    {
        log.ErrorLog(ex.Message);
        Console.WriteLine("Ocorreu um erro durante a execução da aplicação. Por favor, entre em contato com o suporte.");
        Console.WriteLine("Detalhes do erro: " + ex.Message);
    }
}