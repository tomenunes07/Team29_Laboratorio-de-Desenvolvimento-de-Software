using PostDataClass;
using PostInfoClass;
using FacebookIntegration;

public class Model
{
    private readonly IFbIntegration _fbIntegration;
    // Uma instância sda classe FbIntegration que será usada para chamar seus métodos.
    public Model(IFbIntegration fbIntegration)
    {
        _fbIntegration = fbIntegration;
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
