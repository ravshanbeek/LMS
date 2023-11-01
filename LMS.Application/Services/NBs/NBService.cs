using LMS.Application.DTOs;
using LMS.Domen.Entities;
using LMS.Infrastructure.Repositories;
using Mapster;

namespace LMS.Application.Services.NBs;

public class NBService : INBService
{
    private readonly INBRepository _nBRepository;

    public NBService(INBRepository nBRepository) 
        => _nBRepository = nBRepository;

    public async ValueTask<NBDTO> CreateNBAsync(NBForCreation nBForCreation)
    {
        var nb = nBForCreation.Adapt<NB>();
        var addedNb = await _nBRepository.InsertAsync(nb);

        return addedNb.Adapt<NBDTO>();
    }

    public async ValueTask<NBDTO> ModifyNBAsync(NBForModification nBForModification)
    {
        var nb = await _nBRepository.SelectByIdAsync(nBForModification.id);
        //validate
        nb = nBForModification.Adapt(nb);
        var updatedNb = await _nBRepository.UpdateAsync(nb);

        return updatedNb.Adapt<NBDTO>();
    }

    public async ValueTask<NBDTO> RemoveNBAsync(Guid nBId)
    {
        var nb = await _nBRepository.SelectByIdAsync(nBId);
        //validate
        var deletedNB = await _nBRepository.DeleteAsync(nb);

        return deletedNB.Adapt<NBDTO>();
    }

    public async ValueTask<NBDTO> RetrieveNBByIdAsync(Guid nBId)
    {
        var nb = await _nBRepository.SelectByIdAsync(nBId);
        //validate

        return nb.Adapt<NBDTO>();
    }

    public IQueryable<NBDTO> RetrieveNBs()
    {
        var nbs = _nBRepository.SelectAll();

        return nbs.Select(nb => nb.Adapt<NBDTO>());
    }
}
