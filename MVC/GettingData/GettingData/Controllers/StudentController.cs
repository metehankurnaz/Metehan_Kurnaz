using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GettingData.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>()
        {
            new Student(){FirstName="Metehan",LastName="Kurnaz"},
            new Student(){FirstName="Gizem",LastName="Kurnaz"},
            new Student(){FirstName="Erhan",LastName="Kurnaz"},
            new Student(){FirstName="Gülhan",LastName="Kurnaz"}
        };
        public IActionResult GetStudentList()
        {
            return View(students);
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            students.Add(student);
            
            return View("GetStudentList",students);
        }
    }
}
