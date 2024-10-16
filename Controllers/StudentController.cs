using Crud.Data.Models;
using Crud.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }


        [HttpPost("add")]
        public ActionResult AddStudent(Student student)
        {
            try
            {
                string resp = _studentService.AddStudent(student);
                return Ok(new { message = resp });
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("update")]
        public ActionResult UpdateStudent(Student student)
        {
            try
            {
                string resp = _studentService.UpdateStudent(student);
                return Ok(new { message = resp });
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("list")]
        public List<Student> StudentList()
        {
            try
            {
                return _studentService.StudentList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("delete/{id}")]
        public ActionResult DeleteStudent(int id)
        {
            try
            {
                string resp = _studentService.DeleteStudent(id);
                return Ok(new { message = resp });
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
