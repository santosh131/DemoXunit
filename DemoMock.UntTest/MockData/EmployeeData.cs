using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoMock.Models;

namespace DemoMock.UntTest.MockData
{
    public static class EmployeeData
    {
        private static List<EmployeeModel> EmployeeModels
        {
            get
            {
                return new List<EmployeeModel>()
                {
                    new EmployeeModel(){ EmpId=1, Name="Sam", Address="123 St", Email="sam@sam.com"},
                    new EmployeeModel(){ EmpId=5, Name="Tim", Address="456 St", Email="Tim@Tim.com"},
                    new EmployeeModel(){ EmpId=6, Name="Karl", Address="1456 St", Email="Karl@Tim.com"},
                };
            }
        }

        public static List<EmployeeModel> GetEmployeeModels()
        {
            return EmployeeModels;
        }

        public static EmployeeModel GetEmployee(int id)
        {
            return EmployeeModels.Where(x=>x.EmpId==id).FirstOrDefault();
        }
    }
}
