using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskMemtApi.Data.Converter;
using TaskMemtApi.Data.VO;
using TaskMemtApi.Models;

namespace TaskMemtApi.Data.Converters
{
    public class PerformaceAreaConverter : IParse<PerformanceAreaVO, PerformanceArea>, IParse<PerformanceArea, PerformanceAreaVO>
    {
        public PerformanceAreaVO Parse(PerformanceArea origin)
        {
            if (origin == null) return new PerformanceAreaVO();
            return new PerformanceAreaVO
            {
                Id = origin.Id,
                Area = origin.Area,
                specialty = origin.specialty,
                Subject = origin.Subject
            };
        }

        public PerformanceArea Parse(PerformanceAreaVO origin)
        {
            if (origin == null) return new PerformanceArea();
            return new PerformanceArea
            {
                Id = origin.Id,
                Area = origin.Area,
                specialty = origin.specialty,
                Subject = origin.Subject
            };
        }

        public List<PerformanceAreaVO> ParseList(List<PerformanceArea> origin)
        {
            if (origin == null) return new List<PerformanceAreaVO>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<PerformanceArea> ParseList(List<PerformanceAreaVO> origin)
        {
            if (origin == null) return new List<PerformanceArea>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
