using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskMemtApi.Models.Base;

namespace TaskMemtApi.Models
{
    public class Departament : BaseEntity
    {
        public string Leader { get; set; }

        public string NameDepartament { get; set; }

    }
}
