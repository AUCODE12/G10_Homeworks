using ProjectPost.Models;

namespace ProjectPost.Sevices;

public class PostService
{
    private List<Post> posts;

    public PostService()
    {
        posts = new List<Post>();
    }

    public Post AddPost(Post post)
    {
        post.Id = Guid.NewGuid();
        posts.Add(post);

        return post;
    }

    public List<Post> GetAllPosts()
    {
        return posts;
    }

    public Post GetPostById(Guid id)
    {
        foreach (var post in posts)
        {
            if (post.Id == id)
            {
                return post;
            }
        }
        return null;
    }

    public bool UpdatePost(Post updatingPost)
    {
        var postFromDb = GetPostById(updatingPost.Id);

        if (postFromDb is null)
        {
            return false;
        }

        var index = posts.IndexOf(postFromDb);
        posts[index] = updatingPost;
        return true;
    }

    public bool DeletePost(Guid id)
    {
        var postFromDb = GetPostById(id);

        if (postFromDb is null)
        {
            return false;
        }

        posts.Remove(postFromDb);
        return true;
    }

    public Post GetMostViewedPost()
    {
        Post mostViewedPost = null;
        var mostView = 0;
        foreach (var post in posts)
        {
            if (post.ViewerNames.Count > mostView)
            {
                mostView = post.ViewerNames.Count;
                mostViewedPost = post;
            }
        }
        return mostViewedPost;
    }

    public Post GetMostLikedPost()
    {
        Post mostLikedPost = null;
        var mostLike = 0;
        foreach (var post in posts)
        {
            if (post.QuantityLikes > mostLike)
            {
                mostLike = post.QuantityLikes;
                mostLikedPost = post;
            }
        }
        return mostLikedPost;
    }

    public Post GetMostCommentedPost()
    {
        Post mostCommentedPost = null;
        var mostComment = 0;
        foreach (var post in posts)
        {
            if (post.Comments.Count > mostComment)
            {
                mostComment = post.Comments.Count;
                mostCommentedPost = post;
            }
        }
        return mostCommentedPost;
    }

    public List<Post> GetPostsByComment(string comment)
    {
        var ComnetdetPosts = new List<Post>();
        foreach (var post in posts)
        {
            var comments = post.Comments;
            if (comment.Contains(comment) is true)
            {
                ComnetdetPosts.Add(post);
            }
        }
        return ComnetdetPosts;
    }
}
