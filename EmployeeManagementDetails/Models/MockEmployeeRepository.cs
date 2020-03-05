using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementDetails.Models
{
    public class MockEmployeeRepository : IEmployeeRepositary
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id=1,Name="Ankit",Department="M.s" },
                new Employee(){ Id=2,Name="Akash",Department="Mechanical" },
                new Employee(){ Id=3,Name="Shalu",Department="Testing" }
            };
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }
    }
}
