using Application.Declarations.Commands.CategoryCommands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Daily_essentials
{
    [Route("[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExpenseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("/AddCategory")]
        public async Task<ActionResult> AddCategory([FromBody] AddCategoryCommand command)
        {
            return Ok();
        }
    }
}
