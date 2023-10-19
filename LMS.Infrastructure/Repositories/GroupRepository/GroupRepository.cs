using LMS.Domen.Entities;
using LMS.Infrastructure.Contexts;

namespace LMS.Infrastructure.Repositories;

public class GroupRepository : GenericRepository<Group, Guid>, IGroupRepository
{
    public GroupRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
