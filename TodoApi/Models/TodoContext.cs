using Microsoft.EntityFrameworkCore;
//Db context para a aplicação de funcionalidades do Entity Framework.
namespace TodoApi.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options)
    {

    }
    public DbSet<TodoItem> TodoItems { get; set; }
}

