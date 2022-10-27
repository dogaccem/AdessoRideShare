using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.DomainEvents.Routes.Commands.UpdateRoute
{
    public class UpdateRouteCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
    }
}
