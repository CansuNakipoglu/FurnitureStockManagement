namespace FurnitureStockManagement.Object.Requests
{
    public class CreateItemRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageURL { get; set; }
        public int ColorId { get; set; }
    }
}
