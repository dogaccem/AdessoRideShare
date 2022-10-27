using AdessoRideShare.Application.DomainEvents.Users.Commands.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdessoRideShare.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("user")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> AddUserAsync(CreateUserCommand command)
        {
            try
            {

                var item = await _mediator.Send(command);
                return Ok(item);


            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }
    }
}
