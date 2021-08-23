using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class RecordsController : ControllerBase
    {
        private readonly DataContext _context;
        public RecordsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Record>>> GetRecords()
        {
            return await _context.Records.ToListAsync();

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Record>> GetRecord(int id)
        {
            return await _context.Records.FindAsync(id);
        }
    }
}