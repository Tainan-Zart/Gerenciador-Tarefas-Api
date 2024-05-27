using TaskCommander.Communication.Request;
using TaskCommander.Communication.Response;

namespace TaskCommander.Apllication.UseCase.Task.Register;
public class TaskRegisterUseCase
{
    public ResponseRegisterTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseRegisterTaskJson
        { 
           Name = request.Name,
           Description = request.Description,
           Id = request.Id,
        };

    }
}
