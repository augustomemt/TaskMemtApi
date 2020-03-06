using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskMemtApi.Models.Base;

namespace TaskMemtApi.Models
{
    public class PerformanceArea: BaseEntity
    {
        public string Area { get; set; }

        public string Subject { get; set; }

        public string specialty { get; set; }



    }
}
