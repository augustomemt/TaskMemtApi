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
    public class PerformanceAreaBusiness
    {
        private IRepository<PerformanceArea> _repository;

        private readonly PerformaceAreaConverter _converter;

        public PerformanceAreaBusiness(IRepository<PerformanceArea> repository)
        {
            _repository = repository;
            _converter = new PerformaceAreaConverter();
        }



        public PerformanceAreaVO Create(PerformanceAreaVO performanceArea)
        {
            var departamentEntity = _converter.Parse(performanceArea);
            departamentEntity = _repository.Create(_converter.Parse(performanceArea));
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

        public List<PerformanceAreaVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public PerformanceAreaVO FindById(int id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public PerformanceAreaVO Update(PerformanceAreaVO item)
        {
            var departamentntiry = _converter.Parse(item);
            departamentntiry = _repository.Update(_converter.Parse(item));

            return _converter.Parse(departamentntiry);
        }
    }
}
