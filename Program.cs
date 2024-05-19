using FacebookIntegration;
using PostInfoClass;

class Program
{
    static async Task Main(string[] args)
    {
        AppConfig appConfig = new AppConfig();
        IFbIntegration fbIntegration = new FbIntegration(appConfig);
        Model model = new Model(fbIntegration);
        View view = new View();
        List<PostInfo> postInfoList = new List<PostInfo>();
        Controller controller = new Controller(model, view, postInfoList);

        // Inicie o programa chamando um método no Controller
        await controller.StartController();
    }
}