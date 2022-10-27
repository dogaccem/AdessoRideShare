using AdessoRideShare.Application.Abstractions.Repositories;
using AdessoRideShare.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.DomainEvents.Routes.Commands.CreateRoute
{
    public class CreateRouteCommandHandler : IRequestHandler<CreateRouteCommand, Unit>
    {
        private readonly IRouteRepository _routeRepository;
        public CreateRouteCommandHandler(IRouteRepository routeRepository)
        {
            _routeRepository = routeRepository;
        }
        public async Task<Unit> Handle(CreateRouteCommand request, CancellationToken cancellationToken)
        {
            var entity = new Route(request.From, request.To,request.SeatingCapacity,request.UserId);
            await _routeRepository.InsertAsync(entity);
            return Unit.Value;
        }
    }
}
