using AdessoRideShare.Application.Abstractions.Repositories;
using AdessoRideShare.Domain.Entities;
using AdessoRideShare.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdessoRideShare.Application.DomainEvents.Routes.Views;

namespace AdessoRideShare.Infrastructure.Repositories
{
    public class RouteRepository : IRouteRepository
    {
        private readonly AdessoRideShareAppDbContext _dbContext;
        public RouteRepository(AdessoRideShareAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Route> GetRouteAsync(int id)
        {
            var entity = await _dbContext.Routes.FirstOrDefaultAsync(r => r.Id == id);
            if (entity is null)
                throw new ArgumentNullException("Entity cannot be empty");
            return entity;

        }

        public async Task InsertAsync(Route route)
        {
            await _dbContext.AddAsync(route);
            await _dbContext.SaveChangesAsync();
        }

        public async Task InsertParticipantAsync(Participant participant)
        {
            await _dbContext.AddAsync(participant);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IList<RouteVM>> SearchAsync(string? from, string? to)
        {
            var entities = await _dbContext.Routes.Where(r => r.From == from && r.To == to).Select(x=> new RouteVM { From = x.From, To = x.To, SeatingCapacity= x.SeatingCapacity, StartDate=x.StartDate}).ToListAsync();
            return entities;
        }

        public async Task UpdateAsync(int id, bool isActive)
        {
            var entity = await _dbContext.Routes.FirstOrDefaultAsync(r => r.Id == id);
            if (entity is null)
                throw new ArgumentNullException("Entity cannot be empty");

            entity.IsActive = isActive;
            await Task.Run(() => { _dbContext.Routes.Update(entity); });
            await _dbContext.SaveChangesAsync();

        }
    }
}
