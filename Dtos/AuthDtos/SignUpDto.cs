using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reformation.Dtos.AuthDtos
{
    public class SignUpDto
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}