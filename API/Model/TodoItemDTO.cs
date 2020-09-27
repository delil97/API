﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public bool IsComplete { get; set; }
    }
}
