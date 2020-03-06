using System.Collections.Generic;
using TaskMemtApi.Data.VO;

namespace TaskMemtApi.Business
{
    public interface IEmployeesBusiness
    {
        EmployeesVO Create(EmployeesVO contratos);
        EmployeesVO FindById(int id);
        List<EmployeesVO> FindAll();
        List<EmployeesVO> FindByName(string name, string comprador);

        EmployeesVO Update(EmployeesVO item);
        void Delete(int id);

        bool Exists(int? id);
    }
}
