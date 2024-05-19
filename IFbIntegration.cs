using PostDataClass;

public interface IFbIntegration
{
    Task<List<PostData>> GetPostsAsync();
}