﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Quiz
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public string OwnerId { get; set; }

    }
}
