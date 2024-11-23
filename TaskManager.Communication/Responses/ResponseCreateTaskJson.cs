using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Responses;
public class ResponseCreateTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
