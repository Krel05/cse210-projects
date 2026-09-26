public class Video
{
    private List<Comment> _comments;
    private string _title;
    private string _author;
    private int _length;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComments(Comment comment)
    {
        Comment _comment = comment;
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count();
    }

    public string GetDisplayInformation()
    {
        string text = $"Title: {_title}\nAuthor: {_author}\nLength: {_length}\nNumber of comments: {GetNumberOfComments()}\n";

        for (int i = 0; i < _comments.Count(); i++)
        {
            text += $"Comment {i + 1}: {_comments[i].GetDisplayInformation()}\n";
        }

        return text;
    }

}