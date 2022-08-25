using Experts001.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Experts001.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        //sample static list with students
        List<Student> students = new List<Student>()
        { new Student {Name = "Vikas", Class = "X" },
          new Student { Name = "Ramesh", Class = "X" },
        };


        [Route("GetStudents")] //api url to call
        [HttpGet] // we are not using this one for example, but added it for demo
        public List<Student> GetStudents()
        {
            return students;
        }

        [Route("AddStudent")] //api url to call
        [HttpPost] // post to save new student
        public List<Student> AddStudent(Student student)
        {
            students.Add(student);// add new student in list
            return students; // return updated list
        }

    }
}
