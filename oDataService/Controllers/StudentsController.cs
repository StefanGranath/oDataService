using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using oDataService.Models;
using oDataService.Services;

namespace oDataService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentsController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<Student>> GetStudents()
        {
            IQueryable<Student> students = studentService.GetStudents();
            return Ok(students);
        }
    }
}
