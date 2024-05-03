using System.Threading.Tasks;
using Klinik.Application.TodoLists.Commands.CreateTodoList;
using Klinik.Application.TodoLists.Queries.GetTodos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Klinik.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoListsController : ControllerBase
{
    private readonly IMediator _mediator;

    public TodoListsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("GetTodoLists")]
    public async Task<IActionResult> GetTodoLists()
    {
        var result = await _mediator.Send(new GetTodosQuery());

        return Ok(result);
    }

    [HttpPost("CreateTodoList")]
    public async Task<IActionResult> CreateTodoList([FromBody] CreateTodoListCommand command)
    {
        var result = await _mediator.Send(command);

        return Ok(result);
    }
}