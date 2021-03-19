using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreMVCWebApplication.Models;
using FirstCoreMVCWebApplication.DTO;
namespace FirstCoreMVCWebApplication.Controllers
{
    public class StudentController : Controller
    {
        
        private readonly IConfiguration config;
        public StudentController(IConfiguration config1)
        {
            config = config1;
        }
        public IActionResult Index()
        {

            Student model = new Student();

            StudentDTO dto = new StudentDTO();
            model.Students = dto.GetStudents();

            return View(model.Students);
            
        }
    }
}
