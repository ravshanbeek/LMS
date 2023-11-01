using LMS.Application.DTOs;
using LMS.Infrastructure.Repositories;

namespace LMS.Application.Services.Deadline;

public class DedlineService : IDeadlineService
{
    private readonly IDeadlineRepository _deadlineRepository;

    public DedlineService(IDeadlineRepository deadlineRepository)
        => _deadlineRepository = deadlineRepository;

    public ValueTask<DeadlineDTO> CreateDeadlineAsync(DeadlineForCreation deadlineForCreation)
    {
        throw new NotImplementedException();
    }

    public ValueTask<DeadlineDTO> ModifyDeadlineAsync(DeadlineForModification deadlineForModification)
    {
        throw new NotImplementedException();
    }

    public ValueTask<DeadlineDTO> RemoveDeadlineAsync(Guid deadlineId)
    {
        throw new NotImplementedException();
    }

    public ValueTask<DeadlineDTO> RetrieveDeadlineByIdAsync(Guid deadlineId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<DeadlineDTO> RetrieveDeadlines()
    {
        throw new NotImplementedException();
    }
}
