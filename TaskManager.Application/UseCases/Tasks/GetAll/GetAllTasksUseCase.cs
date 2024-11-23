using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.GetAll;
public class GetAllTasksUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson
        {
            Tasks = new List<ResponseShortTaskJson>
            {
                new ResponseShortTaskJson
                {
                    Id = 1,
                    Name = "Fazer homologação",
                    Description = "Fazer homologação no site teste",
                    PriorityType = Communication.Enums.Priority.alta,
                }
            }
        };
    }
}
