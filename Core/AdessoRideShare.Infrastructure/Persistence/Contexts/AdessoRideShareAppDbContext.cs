using AdessoRideShare.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Infrastructure.Persistence.Contexts
{
    public class AdessoRideShareAppDbContext : DbContext
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Route> Routes { get; set; }

        public AdessoRideShareAppDbContext(DbContextOptions<AdessoRideShareAppDbContext> options)
            : base(options)
        { }
    }
}
