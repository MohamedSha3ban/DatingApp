using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppUsersController : ControllerBase
    {
        private readonly DataContext _context;
        public AppUsersController(DataContext context)
        {
            _context = context;
        }

        // api/AppUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetAppUsers ()
        {
            return await _context.AppUsers.ToListAsync();
        }


        // api/AppUsers/3
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetAppUser (int id)
        {
            return await _context.AppUsers.FindAsync(id);
        }
        
    }
}