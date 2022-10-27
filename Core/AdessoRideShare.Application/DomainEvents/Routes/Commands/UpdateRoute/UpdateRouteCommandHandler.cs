using AdessoRideShare.Application.Abstractions.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.DomainEvents.Routes.Commands.UpdateRoute
{
    public class UpdateRouteCommandHandler : IRequestHandler<UpdateRouteCommand, Unit>
    {
        private readonly IRouteRepository _routeRepository;
        public UpdateRouteCommandHandler(IRouteRepository routeRepository)
        {
            _routeRepository = routeRepository;
        }
        public async Task<Unit> Handle(UpdateRouteCommand request, CancellationToken cancellationToken)
        {
            await _routeRepository.UpdateAsync(request.Id,request.IsActive);
            return Unit.Value;
        }
    }
}
