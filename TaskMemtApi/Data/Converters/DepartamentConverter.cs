using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskMemtApi.Data.Converter;
using TaskMemtApi.Data.VO;
using TaskMemtApi.Models;

namespace TaskMemtApi.Data.Converters
{
    public class DepartamentConverter : IParse<DepartamentVO, Departament>, IParse<Departament, DepartamentVO>
    {
        public Departament Parse(DepartamentVO origin)
        {
            if (origin == null) return new Departament();
            return new Departament
            {
                Id = origin.Id,
                NameDepartament = origin.NameDepartament,
                Leader = origin.Leader,
            };
        }

        public DepartamentVO Parse(Departament origin)
        {
            if (origin == null) return new DepartamentVO();
            return new DepartamentVO
            {
                Id = origin.Id,
                NameDepartament = origin.NameDepartament,
                Leader = origin.Leader,
            };
        }

        public List<Departament> ParseList(List<DepartamentVO> origin)
        {
            if (origin == null) return new List<Departament>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<DepartamentVO> ParseList(List<Departament> origin)
        {
            if (origin == null) return new List<DepartamentVO>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
