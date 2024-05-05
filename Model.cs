using System;
using System.Collections.Generic;
using System.Net.Http;
using PostDataClass;
using FacebookIntegration;

public class Model
{
    private readonly FbIntegration _fbIntegration;
    // Uma instância da classe FbIntegration que será usada para chamar seus métodos.
    public Model()
    //Um construtor que aceita uma instância de FbIntegration como argumento e a atribui à variável _fbIntegration.
    {
        AppConfig appConfig = new AppConfig();
        _fbIntegration = new FbIntegration(appConfig);
    }

    public async Task<List<PostData>> GetPostsAsync()
    //chama o método GetPostsAsync() da classe FbIntegration e retorna o resultado diretamente.
    {
        return await _fbIntegration.GetPostsAsync();
    }

}