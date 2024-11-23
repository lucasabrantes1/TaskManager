using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.Register;
public class RegisterTaskUseCase
{
    public ResponseCreateTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseCreateTaskJson
        {
            Id = request.Id,
            Name = request.Name,
        };
    }
}
