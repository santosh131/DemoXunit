using DemoMock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMock.Repository
{
    public interface IEmployeeRepository
    {
        List<EmployeeModel> GetEmployees();

        EmployeeModel GetEmployee(int id);
    }
}
