using TaskCommander.Communication.Response;

namespace TaskCommander.Apllication.UseCase.Task.GetById;
public class GetByIdTaskUseCase
{
    public ResponseTaksJson Execute(int id)
    {
        return new ResponseTaksJson()
        {
            Name = "test",
            Description = "test",
            Id = id,
            Priority = Communication.Enums.TaksPriority.Baixa,
            Status = Communication.Enums.TaskStatus.Concluida,
            TimeLimit = DateTime.UtcNow.AddDays(1)  
            
        };


    }
}
