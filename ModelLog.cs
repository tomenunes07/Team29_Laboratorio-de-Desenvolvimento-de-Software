internal class ModelLog
{
    public delegate void NotificacaoLogAlterado();
    public event NotificacaoLogAlterado NotificarLogAlterado;

    private string log;

    public ModelLog()
    {
        log = "Model error log";
    }

    public void ErrorLog(string Error)
    {
        if (Error != null)
        {
            log = Error;
            NotificarLogAlterado?.Invoke();
        }
        else
        {
            log = "Algum erro aconteceu na chamada da API do facebook";
            NotificarLogAlterado?.Invoke();
        }
    }

    public string GetLog()
    {
        return log;
    }
}