using FurnitureStockManagement.Data;
using FurnitureStockManagement.Object.Requests;
using FurnitureStockManagement.Repositories.Interfaces;
using FurnitureStockManagement.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FurnitureStockManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        public IItemService _itemService { get; set; }
        public ItemController(IItemService itemRepository)
        {
            _itemService = itemRepository;
        }

        [HttpGet]   
        public IActionResult Get()
        {
            return Ok(_itemService.GetAllItems());
        }

        [HttpPost]
        public IActionResult Post(CreateItemRequest createItemRequest)
        {
            _itemService.CreateItem(createItemRequest);
            return Ok();
        }


        [HttpGet("Cansu")]
        public IActionResult Get2()
        {

            return Ok("Cansu Endpointine istek attın tebrikler.");

        }


    }
}
