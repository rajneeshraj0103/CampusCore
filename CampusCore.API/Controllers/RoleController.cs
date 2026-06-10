using CampusCore.Domain.Entities;
using CampusCore.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace CampusCore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly CampusCoreDbContext _context;

        public RoleController(CampusCoreDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateRole([FromBody]Role role)
        {
            _context.Roles.Add(role);

            _context.SaveChanges();

            return Ok(role);
        }

        [HttpGet]
        public IActionResult GetRoles()
        {
            var roles = _context.Roles.ToList();

            return Ok(roles);
        }
    }
}
