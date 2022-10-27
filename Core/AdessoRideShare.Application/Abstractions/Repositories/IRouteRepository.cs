using AdessoRideShare.Application.DomainEvents.Routes.Views;
using AdessoRideShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.Abstractions.Repositories
{
    public interface IRouteRepository
    {
        Task InsertAsync(Route route);
        Task UpdateAsync(int id, bool isActive);
        Task<Route> GetRouteAsync(int id);
        Task InsertParticipantAsync(Participant participant);
        Task<IList<RouteVM>> SearchAsync(string? from, string? to);
    }
}
