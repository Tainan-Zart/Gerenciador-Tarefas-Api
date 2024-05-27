using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using TaskCommander.Apllication.UseCase.Task.Delete;
using TaskCommander.Apllication.UseCase.Task.GetAll;
using TaskCommander.Apllication.UseCase.Task.GetById;
using TaskCommander.Apllication.UseCase.Task.Register;
using TaskCommander.Apllication.UseCase.Task.Update;
using TaskCommander.Communication.Request;
using TaskCommander.Communication.Response;

namespace TaskCommander.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTaskJson) , StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrosJson) , StatusCodes.Status400BadRequest)]

    public IActionResult Create([FromBody] RequestTaskJson request)
    {
        var useCase = new TaskRegisterUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]

    public IActionResult Update ([FromRoute]int id, [FromBody] RequestTaskJson request)
    {
        var useCase = new TaskUpdateUseCase();

        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status204NoContent)]

    public IActionResult GetAll()
    {
        var useCase = new GetAllTaskUseCase();

        var response = useCase.Execute();

        if (response.Taks.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]

    public IActionResult Get([FromRoute]int id)
    {
        var useCase = new GetByIdTaskUseCase();

        var response = useCase.Execute(id);

        return Ok(response);

    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]

    public IActionResult Delete(int id)
    {

        var useCase = new DeleteByIdTaskUseCase();

        useCase.Execute(id);

        return Ok();
    }

}
