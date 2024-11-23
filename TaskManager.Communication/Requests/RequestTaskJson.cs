using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Requests;
public class RequestTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Priority PriorityType { get; set; }
    public DateTime LimitDate { get; set; }
    public Status StatusType { get; set; }
}
