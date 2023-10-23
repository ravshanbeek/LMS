using LMS.Domen.Entities;
using LMS.Infrastructure.Contexts;

namespace LMS.Infrastructure.Repositories;

public class DedlineRepository : GenericRepository<Deadline, Guid>, IDedlineRepository
{
    public DedlineRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
