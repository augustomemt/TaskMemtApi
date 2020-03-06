using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskMemtApi.Data.VO;

namespace TaskMemtApi.Business
{
    public interface ITaskBusiness
    {
        TaskVO Create(TaskVO contratos);
        TaskVO FindById(int id);
        List<TaskVO> FindAll();

        TaskVO Update(TaskVO item);
        void Delete(int id);

        bool Exists(int? id);

    }
}
