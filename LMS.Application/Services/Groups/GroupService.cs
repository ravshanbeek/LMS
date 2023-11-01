using LMS.Application.DTOs;
using LMS.Domen.Entities;
using LMS.Infrastructure.Repositories;
using Mapster;

namespace LMS.Application.Services.Groups;

public class GroupService : IGroupService
{
    private readonly IGroupRepository _groupRepository;

    public GroupService(IGroupRepository groupRepository)
        => _groupRepository = groupRepository;

    public async ValueTask<GroupDTO> CreateGroupAsync(GroupForCreation groupForCreation)
    {
        var group = groupForCreation.Adapt<Group>();
        var addedGroup = await _groupRepository.InsertAsync(group);

        return addedGroup.Adapt<GroupDTO>();
    }

    public async ValueTask<GroupDTO> ModifyGroupAsync(GroupForModification groupForModification)
    {
        var group = await _groupRepository.SelectByIdAsync(groupForModification.id);
        //validate
        group = groupForModification.Adapt(group);
        var updatedGroup = await _groupRepository.UpdateAsync(group);

        return updatedGroup.Adapt<GroupDTO>();
    }

    public async ValueTask<GroupDTO> RemoveGroupAsync(Guid groupId)
    {
        var group = await _groupRepository.SelectByIdAsync(groupId);
        //validate
        var deleteGroup = await _groupRepository.DeleteAsync(group);

        return deleteGroup.Adapt<GroupDTO>();
    }

    public async ValueTask<GroupDTO> RetrieveGroupByIdAsync(Guid groupId)
    {
        var group = await _groupRepository.SelectByIdAsync(groupId);
        //validate

        return group.Adapt<GroupDTO>();
    }

    public IQueryable<GroupDTO> RetrieveGroups()
    {
        var groups = _groupRepository.SelectAll();

        return groups.Select(group => group.Adapt<GroupDTO>());
    }
}
