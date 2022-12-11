namespace FurnitureStockManagement.Object.Requests
{
    public class CreateStockRequest
    {
        public long Quantity { get; set; }
        public long ItemId { get; set;}
        public bool Islocked { get; set;}

    }
}
