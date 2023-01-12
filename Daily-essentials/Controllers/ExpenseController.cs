using Application.Declarations.Commands.CategoryCommands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Daily_essentials.Controllers
{
    public class ExpenseController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExpenseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> AddCategory([FromBody] AddCategoryCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
