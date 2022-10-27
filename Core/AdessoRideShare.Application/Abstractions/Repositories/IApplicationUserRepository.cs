using AdessoRideShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.Abstractions.Repositories
{
    public interface IApplicationUserRepository
    {
        Task InsertAsync(ApplicationUser user);
    }
}
