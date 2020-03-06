using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskMemtApi.Data.Converter;
using TaskMemtApi.Data.VO;
using TaskMemtApi.Models;

namespace TaskMemtApi.Data.Converters
{
    public class SchedulesConverter : IParse<SchedulesVO, Schedules>, IParse<Schedules, SchedulesVO>
    {
        public SchedulesVO Parse(Schedules origin)
        {
            if (origin == null) return new SchedulesVO();
            return new SchedulesVO
            {
                Id = origin.Id,
                Task = origin.Task,
                StartDate = origin.StartDate,
                ComplationDate = origin.ComplationDate,
                EndDate = origin.EndDate,
                PerformanceArea = origin.PerformanceArea,
                PlannedWorkload = origin.PlannedWorkload,
                RegistrationDate = origin.RegistrationDate,
                Request = origin.Request,
                WorkInstruction = origin.WorkInstruction,
            };
        }

        public Schedules Parse(SchedulesVO origin)
        {
            if (origin == null) return new Schedules();
            return new Schedules
            {
                Id = origin.Id,
                Task = origin.Task,
                StartDate = origin.StartDate,
                ComplationDate = origin.ComplationDate,
                EndDate = origin.EndDate,
                PerformanceArea = origin.PerformanceArea,
                PlannedWorkload = origin.PlannedWorkload,
                RegistrationDate = origin.RegistrationDate,
                Request = origin.Request,
                WorkInstruction = origin.WorkInstruction,
            };
        }

        public List<SchedulesVO> ParseList(List<Schedules> origin)
        {
            if (origin == null) return new List<SchedulesVO>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<Schedules> ParseList(List<SchedulesVO> origin)
        {
            if (origin == null) return new List<Schedules>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
