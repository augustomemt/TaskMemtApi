﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TaskMemtApi.Models.Base
{
    [DataContract]
    public class BaseEntity
    {
        public int? Id { get; set; }

    }
}
