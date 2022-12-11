using FurnitureStockManagement.Object.Requests;
using FurnitureStockManagement.Services;
using FurnitureStockManagement.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureStockManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        IStockService _stockService;
        public StockController(IStockService stockService)
        {
            _stockService = stockService;    
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_stockService.GetAllStocks());
        }

        [HttpPost]
        public IActionResult Post(CreateStockRequest createStockRequest)
        {
            _stockService.CreateStock(createStockRequest);     
            return Ok();
        }


    }
}

