using AdessoRideShare.Application.DomainEvents.Routes.Views;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.DomainEvents.Routes.Queries
{
    public class SearchRouteQuery : IRequest<IList<RouteVM>>
    {
        public string? From { get; set; }
        public string? To { get; set; }
    }
}
