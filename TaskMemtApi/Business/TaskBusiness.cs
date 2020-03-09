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
    public class TaskBusiness
    {
        private IRepository<Models.Task> _repository;

        private readonly TaskConverter _converter;

        public TaskBusiness(IRepository<Models.Task> repository)
        {
            _repository = repository;
            _converter = new TaskConverter();
        }



        public TaskVO Create(TaskVO task)
        {
            var departamentEntity = _converter.Parse(task);
            departamentEntity = _repository.Create(_converter.Parse(task));
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

        public List<TaskVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public TaskVO FindById(int id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public TaskVO Update(TaskVO item)
        {
            var departamentntiry = _converter.Parse(item);
            departamentntiry = _repository.Update(_converter.Parse(item));

            return _converter.Parse(departamentntiry);
        }
    }
}
