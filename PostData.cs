//Esta classe pertence ao componente Model
namespace PostDataClass
{
    public class PostData
    {
        public int Id;
        public int AppId;
        public string Description;
        public int ViewCount;
        public int LikeCount;
        public int ReactionCount;
        public string CreationDate;

        // Construtor da classe PostData
        public PostData(int id, int appId, string description, int viewCount, int likeCount, int reactionCount, string creationDate)
        {
            Id = id;
            AppId = appId;
            Description = description;
            ViewCount = viewCount;
            LikeCount = likeCount;
            ReactionCount = reactionCount;
            CreationDate = creationDate;
        }
    }
}
