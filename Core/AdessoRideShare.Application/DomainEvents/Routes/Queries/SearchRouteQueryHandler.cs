using AdessoRideShare.Application.Abstractions.Repositories;
using AdessoRideShare.Application.DomainEvents.Routes.Views;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.DomainEvents.Routes.Queries
{
    public class SearchRouteQueryHandler : IRequestHandler<SearchRouteQuery, IList<RouteVM>>
    {
        private readonly IRouteRepository _routeRepository;
        public SearchRouteQueryHandler(IRouteRepository routeRepository)
        {
            _routeRepository = routeRepository;
        }
        public async Task<IList<RouteVM>> Handle(SearchRouteQuery request, CancellationToken cancellationToken)
        {
            var entites = await _routeRepository.SearchAsync(request.From,request.To);
            return entites;
        }
    }
}
