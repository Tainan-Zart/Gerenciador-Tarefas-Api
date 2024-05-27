using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using TaskCommander.Apllication.UseCase.Task.Register;
using TaskCommander.Communication.Request;
using TaskCommander.Communication.Response;

namespace TaskCommander.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTaskJson) , StatusCodes.Status201Created)]
    

    public IActionResult Create([FromBody] RequestTaskJson request)
    {
        var useCase = new TaskRegisterUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }
}
