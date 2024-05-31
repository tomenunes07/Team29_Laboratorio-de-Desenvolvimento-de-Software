using PostDataClass;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FacebookIntegration
{
    public interface IFbIntegration
    {
        Task<List<PostData>> GetPostsAsync();
    }
}