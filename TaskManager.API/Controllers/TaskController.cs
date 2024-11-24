using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Tasks.Delete;
using TaskManager.Application.UseCases.Tasks.GetAll;
using TaskManager.Application.UseCases.Tasks.Register;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreateTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestTaskJson request)
    {
        var useCase = new RegisterTaskUseCase();
        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }


    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllTasksUseCase();
        var response = useCase.Execute();

        if (response.Tasks.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }


    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult GetById(int id)
    {
        var useCase = new GetAllTasksUseCase();
        var response = useCase.Execute();
        if (response.Tasks.Any())
        {
            return Ok(response);
        }
        return NoContent();
    }



    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskJson request)
    {
        var useCase = new GetAllTasksUseCase();
        var response = useCase.Execute();
        if (response.Tasks.Any())
        {
            return Ok(response);
        }
        return NoContent();
    }


    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete(int id)
    {
        var useCase = new DeleteTaskByIdUseCase();
        useCase.Execute(id);
        return NoContent();
    }

}
