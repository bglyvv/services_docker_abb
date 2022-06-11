using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service1.DAL;
using Service1.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
namespace Service1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly AppDbContext _ctx;

        public SkillsController(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _ctx.Skills.ToListAsync());
        }

        [HttpGet]
        [Route("{id?}")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Skill skill = await _ctx.Skills.FirstOrDefaultAsync(s => s.Id == id);

            if (skill == null)
            {
                return NotFound();
            }

            return Ok(skill);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Skill skill)
        {
            await _ctx.Skills.AddAsync(skill);
            await _ctx.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created, skill);
        }
    }
}
