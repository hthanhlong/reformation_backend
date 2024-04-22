using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reformation.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}

