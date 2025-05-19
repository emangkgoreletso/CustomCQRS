using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;


[ApiController]
[Route("api/[controller]")]
public class ItemController : ControllerBase
{
    private readonly ICommandHandler<CreateItemCommand, string> _handler;

    public ItemController(ICommandHandler<CreateItemCommand, string> handler)
    {
        _handler = handler;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateItemCommand command)
    {
        var result = await _handler.Handle(command, CancellationToken.None);
        return Ok(result);
    }
}
