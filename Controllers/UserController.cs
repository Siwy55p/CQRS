using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Simple_and_Angular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CretateUser(string user)
        {

            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> add(string user)
        {
            //mediator send commend
            int i = 0;
            return Ok();
        }
    }
}
