using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDapperCrud.Data
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeModel>> GetEmployees();
        Task<bool> CreateEmployee(Employee employee);
        Task<bool> EditEmployee(int id, EmployeeModel employee);
        Task<EmployeeModel> SingleEmployee(int id);
        Task<bool> DeleteEmployee(int id);
    }
}
