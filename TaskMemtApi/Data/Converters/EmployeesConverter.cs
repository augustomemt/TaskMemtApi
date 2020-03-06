using System;
using System.Collections.Generic;
using System.Linq;
using TaskMemtApi.Data.Converter;
using TaskMemtApi.Data.VO;
using TaskMemtApi.Models;

namespace TaskMemtApi.Data.Converters
{
    public class EmployeesConverter : IParse<EmployeesVO, Employees>, IParse<Employees, EmployeesVO>
    {
        public Employees Parse(EmployeesVO origin)
        {
            if (origin == null) return new Employees();
            return new Employees
            {
                Id = origin.Id,
                Departament = origin.Departament,
                Email = origin.Email,
                FirstName = origin.FirstName,
                FirstPerformaceArea = origin.FirstPerformaceArea,
                LastName = origin.LastName,
                Machine = origin.Machine,
                Privilege = origin.Privilege,
                SecondPerformaceArea = origin.SecondPerformaceArea,
                ThirdPerformaceArea = origin.ThirdPerformaceArea,
                Registration = origin.Registration

            };
        }

        public EmployeesVO Parse(Employees origin)
        {
            if (origin == null) return new EmployeesVO();
            return new EmployeesVO
            {
                Id = origin.Id,
                Departament = origin.Departament,
                Email = origin.Email,
                FirstName = origin.FirstName,
                FirstPerformaceArea = origin.FirstPerformaceArea,
                LastName = origin.LastName,
                Machine = origin.Machine,
                Privilege = origin.Privilege,
                SecondPerformaceArea = origin.SecondPerformaceArea,
                ThirdPerformaceArea = origin.ThirdPerformaceArea,
                Registration = origin.Registration

            };
        }

        public List<Employees> ParseList(List<EmployeesVO> origin)
        {
            if (origin == null) return new List<Employees>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<EmployeesVO> ParseList(List<Employees> origin)
        {
            if (origin == null) return new List<EmployeesVO>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
