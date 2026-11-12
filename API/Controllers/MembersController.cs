using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Entites;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MembersController(AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<AppUser>>> GetMembers()
        {
            var members = await context.Users.ToListAsync();
            return members;
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetMemeber(string id)
        {
            var member = await context.Users.FindAsync(id);
            if(member == null) return NotFound();
            return member;
        }
    }
}