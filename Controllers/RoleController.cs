using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Reformation.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class RoleController : ControllerBase
    {

        public RoleController()
        {
        }

        [HttpGet]
        public IActionResult GetRoles()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetRole(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddRole()
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRole(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRole(int id)
        {
            return Ok();
        }
    }
}

