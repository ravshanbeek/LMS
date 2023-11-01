using LMS.Domen.Entities;
using LMS.Infrastructure.Contexts;

namespace LMS.Infrastructure.Repositories;

public class TaskGradeRepository : GenericRepository<TaskGrade, Guid>, ITaskGradeRepository
{
    public TaskGradeRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
