using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskMemtApi.Data.Converter;
using TaskMemtApi.Data.VO;
using TaskMemtApi.Models;

namespace TaskMemtApi.Data.Converters
{
    public class TaskConverter : IParse<TaskVO, Models.Task>, IParse<Models.Task, TaskVO>
    {
        public Models.Task Parse(TaskVO origin)
        {
            if (origin == null) return new Models.Task();
            return new Models.Task
            {
                Id = origin.Id,
                NameTask = origin.NameTask,
                PerformaceArea = origin.PerformaceArea,
            };
        }

        public TaskVO Parse(Models.Task origin)
        {

            if (origin == null) return new TaskVO();
            return new TaskVO
            {
                Id = origin.Id,
                NameTask = origin.NameTask,
                PerformaceArea = origin.PerformaceArea,
            };
        }

        public List<Models.Task> ParseList(List<TaskVO> origin)
        {
            if (origin == null) return new List<Models.Task>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<TaskVO> ParseList(List<Models.Task> origin)
        {
            if (origin == null) return new List<TaskVO>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
