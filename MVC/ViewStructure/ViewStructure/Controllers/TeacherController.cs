using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewStructure.Models;

namespace ViewStructure.Controllers
{
    public class TeacherController : Controller
    {
        List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher(){ID=1,Name="metehan",Gender="man"},
            new Teacher(){ID=2,Name="esma",Gender="woman"},
            new Teacher(){ID=3,Name="hakan",Gender="man"},
            new Teacher(){ID=4,Name="feyza",Gender="woman"}
        };
        public IActionResult GetTeacherList()
        {
            return View(teachers);
        }

        public IActionResult DeleteTeacher(int id)
        {
            Teacher teacher = teachers.Find(x => x.ID == id);
            return View(teacher);
        }
    }
}
