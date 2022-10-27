using AdessoRideShare.Application.Abstractions.Repositories;
using AdessoRideShare.Domain.Entities;
using AdessoRideShare.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Infrastructure.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly AdessoRideShareAppDbContext _dbContext;
        public ApplicationUserRepository(AdessoRideShareAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task InsertAsync(ApplicationUser user)
        {
            await _dbContext.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }
    }
}
