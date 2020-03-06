using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskMemtApi.Models.Base;

namespace TaskMemtApi.Models
{
    public class Employees : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Departament Departament { get; set; }

        public string Email { get; set; }

        public string Machine { get; set; }

        public string  Registration { get; set; }

        public string  Privilege{ get; set; }

        public PerformanceArea FirstPerformaceArea { get; set; }

        public PerformanceArea SecondPerformaceArea { get; set; }

        public PerformanceArea ThirdPerformaceArea { get; set; }

    }
}
