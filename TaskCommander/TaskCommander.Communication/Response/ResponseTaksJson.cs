using TaskCommander.Communication.Enums;
using TaskStatus = TaskCommander.Communication.Enums.TaskStatus;

namespace TaskCommander.Communication.Response;
public class ResponseTaksJson
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public TaksPriority Priority { get; set; }

    public DateTime TimeLimit { get; set; }

    public TaskStatus Status { get; set; }
}
