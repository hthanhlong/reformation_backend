using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Reformation.Database;
using Reformation.Models;
using Reformation.Repositories.Interface;

namespace Reformation.Repositories
{
    public class RefreshTokenRepository : GenericRepository<RefreshTokenModel>, IRefreshTokenRepository
    {
        public RefreshTokenRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<RefreshTokenModel?> GetByToken(string token)
        {
            return await _context.RefreshTokenModel.FirstAsync(rt => rt.RefreshToken == token);
        }
    }
}