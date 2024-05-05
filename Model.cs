using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
namespace LabDev.Models
{
    public class Model
    {
        private readonly FbIntegration _fbIntegration;
        // Uma instância da classe FbIntegration que será usada para chamar seus métodos.
        public Model(FbIntegration fbIntegration)
        //Um construtor que aceita uma instância de FbIntegration como argumento e a atribui à variável _fbIntegration.
        {
            _fbIntegration = fbIntegration;
        }

        public async Task<List<PostData>> GetPostsAsync()
        //chama o método GetPostsAsync() da classe FbIntegration e retorna o resultado diretamente.
        {
            return await _fbIntegration.GetPostsAsync();
        }

    }

}
