using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskMemtApi.Data.Converters;
using TaskMemtApi.Data.VO;
using TaskMemtApi.Models;
using TaskMemtApi.Repository.Generic;

namespace TaskMemtApi.Business
{
    public class EmployeesBusiness
    {

        private IRepository<Employees> _repository;

        private readonly EmployeesConverter _converter;

        public EmployeesBusiness(IRepository<Employees> repository)
        {
            _repository = repository;
            _converter = new EmployeesConverter();
        }



        public EmployeesVO Create(EmployeesVO employee)
        {
            var departamentEntity = _converter.Parse(employee);
            departamentEntity = _repository.Create(_converter.Parse(employee));
            return _converter.Parse(departamentEntity);
        }

        public void Delete(int id)
        {
            try
            {
                _repository.Delete(id);


            }
            catch (Exception ex)
            {
                throw ex;
            };
        }

        public bool Exists(int? id)
        {
            throw new NotImplementedException();
        }

        public List<EmployeesVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public EmployeesVO FindById(int id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public EmployeesVO Update(EmployeesVO item)
        {
            var departamentntiry = _converter.Parse(item);
            departamentntiry = _repository.Update(_converter.Parse(item));

            return _converter.Parse(departamentntiry);
        }
    }
}
