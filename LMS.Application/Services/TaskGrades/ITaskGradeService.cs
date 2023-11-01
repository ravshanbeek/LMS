using LMS.Application.DTOs;

namespace LMS.Application.Services.TaskGrades;

public interface ITaskGradeService
{
    //create qilish uchun aniq bo'ladimi yo'qmi bilmadm
    ValueTask<TaskGradeDTO> ModifyTaskGradeAsync(TaskGradeForModificationStudent taskGradeForModificationStudent);
    ValueTask<TaskGradeDTO> ModifyTaskGradeAsync(TaskGradeForModificationTeacher taskGradeForModificationTeacher);
    IQueryable<TaskGradeDTO> RetrieveTaskGrades();
    ValueTask<TaskGradeDTO> RetrieveTaskGradeByIdAsync(Guid taskGradeId);
    ValueTask<TaskGradeDTO> RemoveTaskGradeAsync(Guid taskGradeId);
}
