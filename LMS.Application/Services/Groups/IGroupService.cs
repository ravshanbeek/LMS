using LMS.Application.DTOs;

namespace LMS.Application.Services.Groups;

public interface IGroupService
{
    ValueTask<GroupDTO> CreateGroupAsync(GroupForCreation groupForCreation);
    IQueryable<GroupDTO> RetrieveGroups();
    ValueTask<GroupDTO> RetrieveGroupByIdAsync(Guid groupId);
    ValueTask<GroupDTO> ModifyGroupAsync(GroupForModification groupForModification);
    ValueTask<GroupDTO> RemoveGroupAsync(Guid groupId);
}
