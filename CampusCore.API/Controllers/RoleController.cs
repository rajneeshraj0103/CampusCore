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

        [HttpGet("{id}")]
        public IActionResult GetRoleById(int id)
        {
            var role = _context.Roles.Find(id);

            if (role == null)
            {
                return NotFound();
            }

            return Ok(role);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRole(int id, [FromBody] Role updatedRole)
        {
            var role = _context.Roles.FirstOrDefault(r => r.RoleId == id);

            if (role == null)
            {
                return NotFound();
            }
            role.RoleName = updatedRole.RoleName;
            _context.SaveChanges();
            return Ok(role);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRole(int id)
        {
            var role = _context.Roles.FirstOrDefault(r => r.RoleId ==  id);

            if(role == null)
            {
                return NotFound();
            }

            _context.Roles.Remove(role);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
