namespace CurdAPI.Models
{
    public class TodoList
    {
        public int Id { get; set; }
        public string? Text { get; set; } = string.Empty;
        public bool? IsDone { get; set; } = false;

    }
}
