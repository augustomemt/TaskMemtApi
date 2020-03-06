using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskMemtApi.Models;

namespace TaskMemtApi.Data.VO
{
    public class SchedulesVO
    {
        public int? Id { get; set; }
        public PerformanceArea PerformanceArea { get; set; }

        public Models.Task Task { get; set; }

        public TimeSpan PlannedWorkload { get; set; }

        public DateTime ComplationDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string WorkInstruction { get; set; }

        public string Request { get; set; }

    }
}
