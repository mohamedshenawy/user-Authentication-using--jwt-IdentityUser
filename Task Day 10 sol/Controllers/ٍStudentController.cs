using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Day_10_sol.Data;
using Task_Day_10_sol.Models;

namespace Task_Day_10_sol.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class _ٍStudentController : ControllerBase
    {
        Context context;
        public _ٍStudentController(Context _context)
        {
            context = _context;
        }

        [HttpGet]
        public List<Student> GetAllStudents()
        {
            return context.students.ToList();
        }
        [HttpPost]
        public List<Student> AddStudent(Student std)
        {
            context.students.Add(std);
            return context.students.ToList();
        }
    }
}
