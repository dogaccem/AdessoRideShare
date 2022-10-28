using AdessoRideShare.Application.Abstractions.Repositories;
using AdessoRideShare.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.DomainEvents.Routes.Commands.AddParticipant
{
    public class AddParticipantCommandHandler : IRequestHandler<AddParticipantCommand, Unit>
    {
        private readonly IRouteRepository _routeRepository;
        public AddParticipantCommandHandler(IRouteRepository routeRepository)
        {
            _routeRepository = routeRepository;
        }
        public async Task<Unit> Handle(AddParticipantCommand request, CancellationToken cancellationToken)
        {
            var entity = await _routeRepository.GetRouteAsync(request.RouteId);
            if(entity.Participants.Count() < entity.SeatingCapacity)
            {
                await _routeRepository.InsertParticipantAsync(new Participant(request.FirstName,request.LastName,request.RouteId));
            }
            else
            {
                throw new Exception();
            }

            return Unit.Value;
        }
    }
}
