using LMS.Domen.Entities;
using LMS.Infrastructure.Contexts;

namespace LMS.Infrastructure.Repositories;

public class GradeRepository : GenericRepository<Grade, Guid>, IGradeRepository
{
    public GradeRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
