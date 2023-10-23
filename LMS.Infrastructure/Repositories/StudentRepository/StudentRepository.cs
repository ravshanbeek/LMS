using LMS.Domen.Entities;
using LMS.Infrastructure.Contexts;

namespace LMS.Infrastructure.Repositories;

public class StudentRepository : GenericRepository<Student, Guid>, IStudentRepository
{
    public StudentRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
