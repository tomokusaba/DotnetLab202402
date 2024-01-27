namespace DotnetLab202402.Server.Model;

public class Blog
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public DateTime? Created { get; set; }
    public DateTime? Updated { get; set; }
    public string? Author { get; set; }

}
