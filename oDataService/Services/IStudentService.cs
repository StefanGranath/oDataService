using oDataService.Models;

namespace oDataService.Services
{
    public interface IStudentService
    {
        IQueryable<Student> GetStudents();
    }
}
