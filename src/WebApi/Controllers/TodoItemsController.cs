using System.Threading.Tasks;
using Klinik.Application.TodoItems.Commands.CreateTodoItem;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Randevu.Application.TodoItems.Queries.GetTodoItemsWithPagination;

namespace Klinik.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoItemsController : ControllerBase
{
    private readonly IMediator _mediator;

    public TodoItemsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("GetTodoItemsWithPagination")]
    public async Task<IActionResult> GetTodoItemsWithPagination([FromQuery] GetTodoItemsWithPaginationQuery query)
    {
        var result = await _mediator.Send(query);
        return Ok(result);
    }

    [HttpPost("CreateTodoItem")]
    public async Task<IActionResult> CreateTodoItem([FromBody] CreateTodoItemCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }
}