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
        var responsePost = new Post();
        foreach (var post in posts)
        {
            if (responsePost.ViewerNames.Count < post.ViewerNames.Count)
            {
                responsePost = post;
            }
        }

        return responsePost;
    }

    public Post GetMostLikedPost()
    {
        var responsePost = new Post();
        foreach (var post in posts)
        {
            if (responsePost.QuantityLikes <  post.QuantityLikes)
            {
                responsePost = post;
            }
        }

        return responsePost;
    }

    public Post GetMostCommentedPost()
    {
        var responsePost = new Post();
        foreach (var post in posts)
        {
            if (responsePost.Comments.Count < post.Comments.Count)
            {
                responsePost = post;
            }
        }

        return responsePost;
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

    public bool AddLike(Guid id)
    {
        var postFromDb = GetPostById(id);
        if (postFromDb is null)
        {
            return false;
        }
        postFromDb.QuantityLikes++;
        
        return true;
    }

    public bool AddCommnetToPost(Guid id, string newComment)
    {
        var postFromDb = GetPostById(id);
        if (postFromDb is null)
        {
            return false;
        }
        postFromDb.Comments.Add(newComment);

        return true;
    }

    public bool AddViewerToPost(Guid id, string newUser)
    {
        var postFromDb = GetPostById(id);
        if (postFromDb is null)
        {
            return false;
        }
        postFromDb.ViewerNames.Add(newUser);

        return true;
    }
}
