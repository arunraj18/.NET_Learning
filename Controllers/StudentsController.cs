using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstApp.Repositories;
using FirstApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstApp.Controllers
{
    [Route("api/[controller]")]
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

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

