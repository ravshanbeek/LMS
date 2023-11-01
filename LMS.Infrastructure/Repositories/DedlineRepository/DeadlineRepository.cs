using LMS.Domen.Entities;
using LMS.Infrastructure.Contexts;

namespace LMS.Infrastructure.Repositories;

public class DeadlineRepository : GenericRepository<Deadline, Guid>, IDeadlineRepository
{
    public DeadlineRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
