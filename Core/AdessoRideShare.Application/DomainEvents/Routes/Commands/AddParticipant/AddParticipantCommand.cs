using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.DomainEvents.Routes.Commands.AddParticipant
{
    public class AddParticipantCommand : IRequest<Unit>
    {
        public int RouteId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
