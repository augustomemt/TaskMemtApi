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
    public class DepartamentBusiness : IDepartamentBusiness
    {
        //Injection Dependencies
        private IRepository<Departament> _repository;

        private readonly DepartamentConverter _converter;

        public  DepartamentBusiness(IRepository<Departament> repository)
        {
            _repository = repository;
            _converter = new DepartamentConverter();
        }



        public DepartamentVO Create(DepartamentVO departament)
        {
            var departamentEntity = _converter.Parse(departament);
            departamentEntity = _repository.Create(_converter.Parse(departament));
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

        public List<DepartamentVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public DepartamentVO FindById(int id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public DepartamentVO Update(DepartamentVO item)
        {
            var departamentntiry = _converter.Parse(item);
            departamentntiry = _repository.Update(_converter.Parse(item));

            return _converter.Parse(departamentntiry);
        }
    }
}
