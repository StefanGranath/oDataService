using oDataService.Models;

namespace oDataService.Services
{
    public class StudentService : IStudentService
    {
        private readonly DataContext context;

        public StudentService(DataContext context)
        {
            this.context = context;
        }

        public IQueryable<Student> GetStudents()
        {
            return context.Students.AsQueryable<Student>();
        }
    }
}
