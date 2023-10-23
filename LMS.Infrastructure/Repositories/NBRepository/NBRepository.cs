using LMS.Domen.Entities;
using LMS.Infrastructure.Contexts;

namespace LMS.Infrastructure.Repositories;

public class NBRepository : GenericRepository<NB, Guid>, INBRepository
{
    public NBRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
