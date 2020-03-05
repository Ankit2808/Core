using EmployeeManagementDetails.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementDetails.Controllers
{
    public class HomeController:Controller
    {
        private IEmployeeRepositary _employeeRepository;

        public HomeController(IEmployeeRepositary employeeRepositary)
        {
            _employeeRepository = employeeRepositary;
        }

        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }
    }
}
