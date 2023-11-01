using LMS.Application.DTOs;

namespace LMS.Application.Services.Deadline;

public interface IDeadlineService
{
    ValueTask<DeadlineDTO> CreateDeadlineAsync(DeadlineForCreation deadlineForCreation);
    IQueryable<DeadlineDTO> RetrieveDeadlines();
    ValueTask<DeadlineDTO> RetrieveDeadlineByIdAsync(Guid deadlineId);
    ValueTask<DeadlineDTO> ModifyDeadlineAsync(DeadlineForModification deadlineForModification);
    ValueTask<DeadlineDTO> RemoveDeadlineAsync(Guid deadlineId);
}
