namespace CosmosCRUD.Models
{
    public class Todo
    {
        public required string Id { get; set; }
        public required string Title { get; set; } = string.Empty;
        public required string Description { get; set; } = string.Empty;
    }
}
