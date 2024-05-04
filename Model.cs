using System;
using Facebook;

public class FacebookModel
{
    private object _accessToken;
    private readonly FacebookClient _facebookClient;
	private readonly string _accesToken;
    private object IdPost;

    public object? accessToken { get; private set; }

    public FacebookModel(string accesToken)
	{
         _accessToken = accessToken;
        _facebookClient = new FacebookClient((string)accessToken);
    }
	public int GetLinkClicks(string IdPost)
	{
        dynamic insight = _facebookClient.Get($"{IdPost}/insights/post_clicks");

            foreach (dynamic insights in insight.data)
		{
            if (insight.name=="post_clicks")
            {
				return insight.values[0].value;
            }
        }
        return 0;
	}
	public int GetEngagement(string IdPost)
	{
		dynamic post = _facebookClient.Get(IdPost);
		int likes = post.likes.summary.total_count;
		int comments = post.comments.summary.total_count;
		int shares = post.shares.summary.total_count;
		return likes+comments+shares;
	}
	public int CalculateReach(string IdPost)
	{
		dynamic insight = _facebookClient.Get(IdPost);
        int likes = insight.likes.summary.total_count;
        int comments = insight.comments.summary.total_count;
        int shares = insight.shares.summary.total_count;
        int views = insight.insight.data[0].values[0].value;
		return likes+comments+views+shares;
    }
    public double CalculateRelevance(string IdPost)
	{
        dynamic post = _facebookClient.Get(IdPost);
        double perInteractions;//ver isto com quem estiver a fazer Views
        double perViews;//ver isto com quem estiver a fazer Views
        int likes = post.likes.summary.total_count;
        int comments = post.comments.summary.total_count;
        int shares = post.shares.count;
        int views = post.insight.data[0].values[0].value;
        //Considerando a Relevância como uma média ponderada das métricas likes, comments, shares e views:
        //As porcentagens podem ser ajustadas segundo o interesse do usuario.
        //Para realizar o ajuste pode ser chamado um script para o usuario entrar as porcentagens de Peso das interações e Peso das vizualizações.
        double totalInteractions = likes + comments + shares;
        double weightedInteractions = totalInteractions * 0.7;
        //double weightedInteractions = totalInteractions * perInteractions;
        double weightedViews = views * 0.3;
        //double weightedViews = views * perViews;
        return (weightedInteractions + weightedViews) / 1000;
    }

}
