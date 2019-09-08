using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IService;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace ImageMall_Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public int Add(Student student)
        {
            var stu = new Student
            {
                Id = 1,
                Name = "张三",
                Age = 19
            };
            _studentService.Insert(student);
            return 1;
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}