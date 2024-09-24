namespace TodoApi.Models.TodoItem
{
    public record TodoItemDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; } = string.Empty;
    }
}
