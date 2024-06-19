namespace BooksManager.Comunication.Request;

public class RequestRedisterBook
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string author { get; set; }
    public string kind { get; set; }
    public int price { get; set; }
    public int stock { get; set; }
}
