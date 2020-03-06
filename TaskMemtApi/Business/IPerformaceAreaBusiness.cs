using System.Collections.Generic;
using TaskMemtApi.Data.VO;

namespace TaskMemtApi.Business
{
    public interface IPerformaceAreaBusiness
    {

        PerformanceAreaVO Create(PerformanceAreaVO contratos);
        PerformanceAreaVO FindById(int id);
        List<PerformanceAreaVO> FindAll();     

        PerformanceAreaVO Update(PerformanceAreaVO item);
        void Delete(int id);

        bool Exists(int? id);


    }
}
