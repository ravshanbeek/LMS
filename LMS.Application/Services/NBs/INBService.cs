using LMS.Application.DTOs;

namespace LMS.Application.Services.NBs;

public interface INBService
{
    ValueTask<NBDTO> CreateNBAsync(NBForCreation nBForCreation);
    IQueryable<NBDTO> RetrieveNBs();
    ValueTask<NBDTO> RetrieveNBByIdAsync(Guid nBId);
    ValueTask<NBDTO> ModifyNBAsync(NBForModification nBForModification);
    ValueTask<NBDTO> RemoveNBAsync(Guid nBId);
}
