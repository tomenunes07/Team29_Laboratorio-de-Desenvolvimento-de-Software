using PostDataClass;
using PostInfoClass;
using FacebookIntegration;

public class Model
{
    private readonly FbIntegration _fbIntegration;
    // Uma instância sda classe FbIntegration que será usada para chamar seus métodos.
    public Model()
    //Um construtor que aceita uma instância de FbIntegration como argumento e a atribui à variável _fbIntegration.
    {
        AppConfig appConfig = new AppConfig();
        _fbIntegration = new FbIntegration(appConfig);
    }

    public async Task<List<PostInfo>> GetPostsAsync()
    //chama o método GetPostsAsync() da classe FbIntegration e retorna o resultado diretamente.
    {
        List<PostData> postDataList = await _fbIntegration.GetPostsAsync();

        List<PostInfo> postInfoList = postDataList.Select(postData =>
            new PostInfo(
                postData.Description,
                postData.ViewCount,
                postData.LikeCount,
                postData.ReactionCount,
                postData.CreationDate
            )).ToList();

        return postInfoList;
    }
}
