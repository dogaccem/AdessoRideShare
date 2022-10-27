using AdessoRideShare.Application.Abstractions.Repositories;
using AdessoRideShare.Domain.Entities;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.DomainEvents.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Unit>
    {
        private readonly IApplicationUserRepository _applicationUserRepository;
        public CreateUserCommandHandler(IApplicationUserRepository applicationUserRepository)
        {
            _applicationUserRepository = applicationUserRepository;
        }
        public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var entity = new ApplicationUser(request.FirstName,request.LastName);
            await _applicationUserRepository.InsertAsync(entity);
            return Unit.Value;
        }
    }
}
