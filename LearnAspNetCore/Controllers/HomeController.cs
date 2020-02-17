using LearnAspNetCore.Models;
using LearnAspNetCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnAspNetCore.Controllers
{
    public class HomeController:Controller
    {
        private readonly IEmployeeRepository _employeeRespository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRespository = employeeRepository;
        }
        public string Index()
        {
            return _employeeRespository.GetEmployee(1).Name;
        }

        public ViewResult Details()
        {

            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRespository.GetEmployee(1),
                PageTitle = "Employee Details"
            };
            
            return View(homeDetailsViewModel);
        }
    }
}
