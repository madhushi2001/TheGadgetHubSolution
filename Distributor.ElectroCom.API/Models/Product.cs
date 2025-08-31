namespace Distributor.ElectroCom.API.Models
{
    public class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal PricePerUnit { get; set; }
        public int AvailableQuantity { get; set; }
        public int EstimatedDeliveryDays { get; set; }
    }
}
