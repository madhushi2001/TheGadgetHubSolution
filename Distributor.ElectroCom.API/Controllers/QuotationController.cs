using Microsoft.AspNetCore.Mvc;
using Distributor.ElectroCom.API.Models;
using System.Linq;

namespace Distributor.ElectroCom.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuotationController : ControllerBase
    {
        private readonly AppDbContext _context;

        public QuotationController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult GetQuotation([FromBody] QuotationRequest request)
        {
            var product = _context.Products
                .FirstOrDefault(p => p.ProductID == request.ProductID);

            if (product == null)
                return NotFound("Product not found.");

            var response = new QuotationResponse
            {
                Distributor = "ElectroCom",
                ProductId = product.ProductID,
                PricePerUnit = product.PricePerUnit,
                AvailableQuantity = product.AvailableQuantity,
                EstimatedDeliveryDays = product.EstimatedDeliveryDays
            };

            return Ok(response);
        }
    }

    public class QuotationRequest
    {
        public string ProductID { get; set; }
        public int Quantity { get; set; }
    }

    public class QuotationResponse
    {
        public string Distributor { get; set; }
        public string ProductId { get; set; }
        public decimal PricePerUnit { get; set; }
        public int AvailableQuantity { get; set; }
        public int EstimatedDeliveryDays { get; set; }
    }
}
