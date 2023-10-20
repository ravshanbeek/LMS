using LMS.Domen.Entities;
using LMS.Infrastructure.Contexts;

namespace LMS.Infrastructure.Repositories;

public class SubjectRepository : GenericRepository<Subject, Guid>, ISubjectRepository
{
    public SubjectRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
