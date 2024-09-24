namespace TodoApi.Models.TodoItem;
//Classes modelo para uso da API/Db.
public class TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
    public string? Password { get; set; }
    public string? Secret { get; set; }
}

