using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.GetById;
public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id) 
    {
        return new ResponseTaskJson
        {
            Id = id,
            Name = "Fazer Teste",
            Description = "Fazer teste da aplicação e testes automatizados",
            PriorityType = 0
        };
    }
}
