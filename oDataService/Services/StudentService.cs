using oDataService.Models;

namespace oDataService.Services
{
    public class StudentService : IStudentService
    {
        public IQueryable<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Stefan Granath",
                    Score = 200
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Adam Bertilsson",
                    Score = 150
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Sanna Larsson",
                    Score = 170
                }
            }.AsQueryable();
        }
    }
}
