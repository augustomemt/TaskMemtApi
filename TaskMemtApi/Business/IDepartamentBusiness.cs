using System.Collections.Generic;
using TaskMemtApi.Data.VO;
using TaskMemtApi.Models;

namespace TaskMemtApi.Business
{
    public interface IDepartamentBusiness
    {
        DepartamentVO Create(DepartamentVO contratos);
        DepartamentVO FindById(int id);
        List<DepartamentVO> FindAll();
        DepartamentVO Update(DepartamentVO item);
        void Delete(int id);

        bool Exists(int? id);
    }
}
