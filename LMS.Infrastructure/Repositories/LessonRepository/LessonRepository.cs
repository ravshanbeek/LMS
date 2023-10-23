using LMS.Domen.Entities;
using LMS.Infrastructure.Contexts;

namespace LMS.Infrastructure.Repositories;

public class LessonRepository : GenericRepository<Lesson, Guid>, ILessonRepository
{
    public LessonRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
