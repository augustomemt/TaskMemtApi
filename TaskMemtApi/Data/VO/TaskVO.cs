using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskMemtApi.Models;

namespace TaskMemtApi.Data.VO
{
    public class TaskVO
    {

        public int? Id { get; set; }
        public PerformanceArea PerformaceArea { get; set; }

        public string NameTask { get; set; }
    }
}
