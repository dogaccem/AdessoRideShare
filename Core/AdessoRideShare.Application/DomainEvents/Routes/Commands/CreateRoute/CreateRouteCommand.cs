using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.DomainEvents.Routes.Commands.CreateRoute
{
    public class CreateRouteCommand : IRequest<Unit>
    {
        public string? From { get; set; }
        public string? To { get; set; }
        public int SeatingCapacity { get; set; }
        public int UserId { get; set; }
    }
}
