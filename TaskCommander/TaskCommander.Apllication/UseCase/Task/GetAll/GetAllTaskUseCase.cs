using System.Linq.Expressions;
using TaskCommander.Communication.Request;
using TaskCommander.Communication.Response;

namespace TaskCommander.Apllication.UseCase.Task.GetAll;
public class GetAllTaskUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson
        {

           /* Taks = new List<ResponseShortTaskJson> 
            { 
                new ResponseShortTaskJson
                {
                    Id = 1,
                    Name = "Test",
                    Description = "Test",
                }
                
            
            }
           */
        };

    }
}
