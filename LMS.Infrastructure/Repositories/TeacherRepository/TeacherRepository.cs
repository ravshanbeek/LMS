using LMS.Domen.Entities;
using LMS.Infrastructure.Contexts;

namespace LMS.Infrastructure.Repositories;

public class TeacherRepository : GenericRepository<Teacher, Guid>, ITeacherRepository
{
    public TeacherRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
