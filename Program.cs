class Program
{
    static async Task Main(string[] args)
    {
        // Crie uma inst�ncia do Controller, passando a View como argumento
        Controller controller = new Controller();

        // Inicie o programa chamando um m�todo no Controller
        await controller.StartController();
    }
}