class Program
{
    static async Task Main(string[] args)
    {
        // Crie uma instância do Controller, passando a View como argumento
        Controller controller = new Controller();

        // Inicie o programa chamando um método no Controller
        await controller.StartController();
    }
}