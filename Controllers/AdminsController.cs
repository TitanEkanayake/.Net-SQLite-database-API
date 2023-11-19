using CurdAPI.Data;
using CurdAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CurdAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {

        private readonly AppDbContext appDbContext;

        public AdminsController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        //Add Admin
        [HttpPost]
        public async Task<ActionResult<List<Admins>>> AddAdmin(Admins newAdmin)
        {
            if (newAdmin != null)
            {
                appDbContext.Admins.Add(newAdmin);
                await appDbContext.SaveChangesAsync();


                var Admins = await appDbContext.Admins.ToListAsync();
                return Ok(Admins);
            }
            return BadRequest();
        }

        //Read all Admins
        [HttpGet]
        public async Task<ActionResult<List<Admins>>> GetAdmins()
        {
            var Admins = await appDbContext.Admins.ToListAsync();
            return Ok(Admins);
        }

        //Read single Admin
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Admins>> GetEmployee(int id)
        {
            var Admin = await appDbContext.Admins.FirstOrDefaultAsync(e => e.Id == id);
            if (Admin != null)
            {
                return Ok(Admin);
            }
            return NotFound("Admin Not Found !");
        }

        
    }
}
