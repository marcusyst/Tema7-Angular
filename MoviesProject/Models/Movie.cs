﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesProject.Models
{
    public class Movie
    {
        public Guid id { get; set; }

        public string name { get; set; }

        public string type { get; set; }
    }
}
