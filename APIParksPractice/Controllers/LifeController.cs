using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using APIParksPractice.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIParksPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LifeController : Controller
    {
        private readonly LifeExpectancyDbContext _context;
        public LifeController(LifeExpectancyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Life>> GetStats()
        {
            return await _context.Life.ToListAsync();
        }
    }
}