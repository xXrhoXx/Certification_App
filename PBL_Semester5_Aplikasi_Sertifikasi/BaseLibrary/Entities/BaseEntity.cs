﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class BaseEntity
    {
        public int id { get; set; }
        public string? name { get; set; }
        [JsonIgnore]
        public List<Assesse>? assesses { get; set; }
    }
}
