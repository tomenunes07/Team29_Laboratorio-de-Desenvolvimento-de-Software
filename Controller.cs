using System;

namespace Controller
{
    internal class Controller
    {
        private Model model;
        private View view;
        private AppConfig appconfig;

        public Controller()
        {
            model = new Model();
            view = new View();
            appconfig = new AppConfig();

            // Inscrever-se no evento MenuChoiceMade da View
            view.MenuChoiceMade += HandleMenuChoice;
        }

        public void StartController()
        {
            ShowMainMenu();
        }

        private void HandleMenuChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    // Chamar a função FuncaoOpcao1() no Controller
                    FuncaoOpcao1();
                    break;
                case "2":
                    // Lógica para a opção 2...
                    break;
                case "3":
                    // Lógica para a opção 3...
                    break;
                default:
                    throw new ArgumentException("Opção inválida. Tente novamente.");
            }
        }

        private void FuncaoOpcao1()
        {
            // Implementação da funcionalidade da opção 1 no Controller...
        }

        private void ShowMainMenu()
        {
            // Mostrar o menu principal ao usuário
            view.ShowMainMenu();
        }
    }
}

/*
 *          FbIntegration manager = new FbIntegration(appConfig); //passar para o model
            List<PostData> posts = await manager.GetPostsAsync(); //passar para o model
*/