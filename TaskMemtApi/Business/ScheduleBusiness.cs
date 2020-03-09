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
    public class ScheduleBusiness
    {
        private IRepository<Schedules> _repository;

        private readonly SchedulesConverter _converter;

        public ScheduleBusiness(IRepository<Schedules> repository)
        {
            _repository = repository;
            _converter = new SchedulesConverter();
        }



        public SchedulesVO Create(SchedulesVO schedules)
        {
            var departamentEntity = _converter.Parse(schedules);
            departamentEntity = _repository.Create(_converter.Parse(schedules));
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

        public List<SchedulesVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public SchedulesVO FindById(int id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public SchedulesVO Update(SchedulesVO item)
        {
            var departamentntiry = _converter.Parse(item);
            departamentntiry = _repository.Update(_converter.Parse(item));

            return _converter.Parse(departamentntiry);
        }
    }
}
