using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskMemtApi.Models.Base;

namespace TaskMemtApi.Models
{
    public partial class Schedules : BaseEntity
    {

        public PerformanceArea PerformanceArea { get; set; }

        public Task Task { get; set; }

        public TimeSpan PlannedWorkload { get; set; }

        public DateTime ComplationDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string WorkInstruction { get; set; }

        public string Request { get; set; }

    }
}
