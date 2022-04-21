using DemoMock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMock.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<EmployeeModel> EmployeeModels
        {
            get
            {
                return new List<EmployeeModel>()
                {
                    new EmployeeModel(){ EmpId=1, Name="Sam", Address="123 St", Email="sam@sam.com"},
                    new EmployeeModel(){ EmpId=2, Name="Tim", Address="456 St", Email="Tim@Tim.com"},
                    new EmployeeModel(){ EmpId=3, Name="Karl", Address="1456 St", Email="Karl@Tim.com"},
                };
            }
        }
        public EmployeeModel GetEmployee(int id)
        {
            return EmployeeModels.Where(a => a.EmpId == id).FirstOrDefault();
        }

        public List<EmployeeModel> GetEmployees()
        {
            return EmployeeModels;
        }
    }
}
