//Esta classe pertence ao componente Model
namespace PostInfoClass
{
    public class PostInfo
    {
        public string Description;
        public int ViewCount;
        public int LikeCount;
        public int ReactionCount;
        public string CreationDate;

        // Construtor da classe PostData
        public PostInfo(string description, int viewCount, int likeCount, int reactionCount, string creationDate)
        {
            Description = description;
            ViewCount = viewCount;
            LikeCount = likeCount;
            ReactionCount = reactionCount;
            CreationDate = creationDate;
        }
    }
}
