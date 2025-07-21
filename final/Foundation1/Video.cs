public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public int ObtainNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayComment()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();

        }
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} by {_author}. Video Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {ObtainNumberOfComments()}.");

        DisplayComment();
    }
}