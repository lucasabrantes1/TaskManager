﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Communication.Responses;
public class ResponseErrorJson
{
    List<string> Errors { get; set; } = [];
}
