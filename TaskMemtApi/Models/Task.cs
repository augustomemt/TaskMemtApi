using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskMemtApi.Models.Base;

namespace TaskMemtApi.Models
{
    public class Task : BaseEntity
    {

        public PerformanceArea PerformaceArea { get; set; }

        public string NameTask { get; set; }

    }
}
