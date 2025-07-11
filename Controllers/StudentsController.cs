using FirstApp.Models;
using FirstApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        [HttpPut]
        public IActionResult UpdateStudents([FromBody] Student student) {
            if (student == null || student.Id <= 0)
            {
                return BadRequest();
            }
            var currStudent = StudentRepository.students.Where(s => s.Id == student.Id).FirstOrDefault();
            StudentRepository.students.Remove(currStudent);
            if (currStudent == null)
            {
                return NotFound();
            }
            currStudent.Id = student.Id;
            currStudent.Name = student.Name;
            currStudent.Email = student.Email;
            currStudent.EnrollmentDate = student.EnrollmentDate;
            StudentRepository.students.Add(currStudent);
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
