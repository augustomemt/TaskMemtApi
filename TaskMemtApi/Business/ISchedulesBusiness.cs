using System.Collections.Generic;
using TaskMemtApi.Data.VO;

namespace TaskMemtApi.Business
{
    public interface ISchedulesBusiness
    {
        SchedulesVO Create(SchedulesVO contratos);
        SchedulesVO FindById(int id);
        List<SchedulesVO> FindAll();

        SchedulesVO Update(SchedulesVO item);
        void Delete(int id);

        bool Exists(int? id);
    }
}
