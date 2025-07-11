
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstApp.Repositories;
using FirstApp.Models;

namespace FirstApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            return Ok(StudentRepository.students);
        }

        // GET api/values/5
        [HttpGet("{id:int}")]
        public ActionResult<Student> Get(int id)
        {
            if (id <= 0)
                return BadRequest();
            var stu = StudentRepository.students.Where(n => n.Id == id).FirstOrDefault();

            if (stu == null)
            {
                return NotFound();
            }
            return Ok(stu);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Student> Create([FromBody] Student student)
        {
            if (student == null)
                return BadRequest();

            int newId = StudentRepository.students.LastOrDefault().Id + 1;
            Student stu = new Student
            {
                Id = newId,
                Name = student.Name,
                Email = student.Email,
                EnrollmentDate = DateTime.Now
            };
            StudentRepository.students.Add(stu);
            student.Id = stu.Id;
            return Ok(student);
        }

        [HttpPut]
        public IActionResult UpdateStudents([FromBody] Student student) {
            if (student == null || student.Id <= 0)
            {
                return BadRequest();
            }
            var currStudent = StudentRepository.students.Where(s => s.Id == student.Id).FirstOrDefault();
            if (currStudent == null)
            {
                return NotFound();
            }
            currStudent.Id = student.Id;
            currStudent.Name = student.Name;
            currStudent.Email = student.Email;
            currStudent.EnrollmentDate = student.EnrollmentDate;
            return Ok();
        
        
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteStudent(int studentId)
        {
            if (studentId <= 0) {
                return BadRequest();
            }
            var currStudent = StudentRepository.students.Where(s => s.Id == studentId).FirstOrDefault();
            if (currStudent == null)
            {
                return NotFound();
            }
            StudentRepository.students.Remove(currStudent);
            return NoContent();
      }
  }
}
