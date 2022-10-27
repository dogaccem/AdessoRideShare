using AdessoRideShare.Application.DomainEvents.Routes.Commands.AddParticipant;
using AdessoRideShare.Application.DomainEvents.Routes.Commands.CreateRoute;
using AdessoRideShare.Application.DomainEvents.Routes.Commands.UpdateRoute;
using AdessoRideShare.Application.DomainEvents.Routes.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AdessoRideShare.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RouteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("route")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> AddRouteAsync(CreateRouteCommand command)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var item = await _mediator.Send(command);
                    return Ok(item);
                }
                return BadRequest("");

            }
            catch (Exception ex)
            {

                return BadRequest("failed");
            }
        }

        [HttpPut("route/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> UpdateTenantAsync(int id, UpdateRouteCommand command)
        {
            try
            {

            
                    command.Id = id;
                    var item = await _mediator.Send(command);
                    return Ok("route updated!");

            }
            catch (Exception ex)
            {

                return BadRequest("");
            }
        }

        [HttpPost("participant")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> AddParticipantAsync(AddParticipantCommand command)
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

        [HttpGet("search")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> SearchAsync([FromQuery] SearchRouteQuery searchParameters)
        {
            try
            {
                var items = await _mediator.Send(searchParameters);
                return Ok(items);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
