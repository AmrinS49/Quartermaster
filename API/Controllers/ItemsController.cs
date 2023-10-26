using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ItemsController : BaseApiController
    {
        private readonly DataContext _context;
        public ItemsController(DataContext context)
        {
            _context = context;
        }
        
        [HttpGet] //api/items
        public async Task<ActionResult<List<Item>>> GetItems()
        {
            return await _context.Items.ToListAsync();
        }

        [HttpGet("{id}")]   //api/items/example
        public  async Task<ActionResult<Item>> GetItem(string sku)
        {
            return await _context.Items.FindAsync(sku);
        }

    }
}