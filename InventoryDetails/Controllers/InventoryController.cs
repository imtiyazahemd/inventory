using InventoryDetails.Modal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InventoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Items
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inventory>>> GetItems()
        {
            return await _context.Inventory.ToListAsync();
        }

        [HttpGet("GetItems_forUpdate")]
        public async Task<ActionResult<IEnumerable<Inventory>>> GetItems_forUpdate()
        {
            return await _context.Inventory.ToListAsync();
        }
    }
}
