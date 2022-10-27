using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.DomainEvents.Users.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<Unit>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
