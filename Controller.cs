using System;
internal class Controller
{
    private Model model;
    private View view;

    public Controller()
    {
        this.model = new Model();
        this.view = new View();

        // Inscrever-se no evento MenuChoiceMade da View
        this.view.MenuChoiceMade += HandleMenuChoice;
    }

    public void StartController()
    {
        view.ShowMainMenu();
    }

    private void HandleMenuChoice(string choice)
    {
        switch (choice)
        {
            case "1":
                // Chamar a fun��o FuncaoOpcao1() no Controller
                FuncaoOpcao1();
                break;
            case "2":
                // L�gica para a op��o 2...
                break;
            case "3":
                // L�gica para a op��o 3...
                break;
            default:
                throw new ArgumentException("Op��o inv�lida. Tente novamente.");
        }
    }

    private void FuncaoOpcao1()
    {
        // Implementa��o da funcionalidade da op��o 1 no Controller...
    }

    private void ShowMainMenu()
    {
        // Mostrar o menu principal ao usu�rio
        view.ShowMainMenu();
    }
}


/*
 *          FbIntegration manager = new FbIntegration(appConfig); //passar para o model
            List<PostData> posts = await manager.GetPostsAsync(); //passar para o model
*/