using LearnAspNetCore.Models;
using LearnAspNetCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnAspNetCore.Controllers
{
    //[Route("Home")]
    [Route("[controller]/[action]")]
    public class HomeController:Controller
    {
        private readonly IEmployeeRepository _employeeRespository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRespository = employeeRepository;
        }

        //other attribute routing options
        //[Route("Home")]
        //[Route("Home/Index")]
        //[Route("[action]")]
        [Route("")]
        [Route("~/")]
        public ViewResult Index()
        {
            var model = _employeeRespository.GetAllEmployee();

            return View(model);
        }

        //other attribute routing options
        //[Route("Home/Details/{id?}")]
        //[Route("[action]")]

        [Route("{id?}")]
        public ViewResult Details(int? id)
        {

            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRespository.GetEmployee(id ?? 1),
                PageTitle = "Employee Details"
            };
            
            return View(homeDetailsViewModel);
        }


    }
}
