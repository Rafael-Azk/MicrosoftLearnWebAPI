using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models.TodoItem;
//Classes modelo para uso da API/Db.
public class TodoItem
{
    public long Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Password { get; set; }
    public string? Secret { get; set; }
}

