using LMS.Application.DTOs;
using LMS.Domen.Entities;
using LMS.Infrastructure.Repositories;
using Mapster;

namespace LMS.Application.Services.Deadlines;

public class DedlineService : IDeadlineService
{
    private readonly IDeadlineRepository _deadlineRepository;

    public DedlineService(IDeadlineRepository deadlineRepository)
        => _deadlineRepository = deadlineRepository;

    public async ValueTask<DeadlineDTO> CreateDeadlineAsync(DeadlineForCreation deadlineForCreation)
    {
        var deadline = deadlineForCreation.Adapt<Deadline>();
        var addedDeadline = await _deadlineRepository.InsertAsync(deadline);

        return addedDeadline.Adapt<DeadlineDTO>();
    }

    public async ValueTask<DeadlineDTO> ModifyDeadlineAsync(DeadlineForModification deadlineForModification)
    {
        var deadline = await _deadlineRepository.SelectByIdAsync(deadlineForModification.id);
        //validate
        deadline = deadlineForModification.Adapt(deadline);
        var updatedDeadline = await _deadlineRepository.UpdateAsync(deadline);

        return updatedDeadline.Adapt<DeadlineDTO>();
    }

    public async ValueTask<DeadlineDTO> RemoveDeadlineAsync(Guid deadlineId)
    {
        var deadline = await _deadlineRepository.SelectByIdAsync(deadlineId);
        //validate
        var deletedDeadline = await _deadlineRepository.DeleteAsync(deadline);

        return deletedDeadline.Adapt<DeadlineDTO>();
    }

    public async ValueTask<DeadlineDTO> RetrieveDeadlineByIdAsync(Guid deadlineId)
    {
        var deadline = await _deadlineRepository.SelectByIdAsync(deadlineId);
        //validate

        return deadline.Adapt<DeadlineDTO>();
    }

    public IQueryable<DeadlineDTO> RetrieveDeadlines()
    {
        var deadlines = _deadlineRepository.SelectAll();

        return deadlines.Select(deadline => deadline.Adapt<DeadlineDTO>());
    }
}
