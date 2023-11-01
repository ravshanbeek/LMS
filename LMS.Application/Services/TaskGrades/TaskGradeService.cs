using LMS.Application.DTOs;
using LMS.Application.Services.TaskGrades;
using LMS.Infrastructure.Repositories;
using Mapster;

namespace LMS.Application.Services.Grades;

public class TaskGradeService : ITaskGradeService
{
    private readonly ITaskGradeRepository _taskGradeRepository;

    public TaskGradeService(ITaskGradeRepository taskGradeRepository)
        => _taskGradeRepository = taskGradeRepository;

    public async ValueTask<TaskGradeDTO> ModifyTaskGradeAsync(TaskGradeForModificationStudent taskGradeForModificationStudent)
    {
        var taskGrade = await _taskGradeRepository.SelectByIdAsync(taskGradeForModificationStudent.id);
        //validate
        taskGrade = taskGradeForModificationStudent.Adapt(taskGrade);
        var updatedTaskGrade = await _taskGradeRepository.UpdateAsync(taskGrade);
        
        return updatedTaskGrade.Adapt<TaskGradeDTO>();
    }

    public async ValueTask<TaskGradeDTO> ModifyTaskGradeAsync(TaskGradeForModificationTeacher taskGradeForModificationTeacher)
    {
        var taskGrade = await _taskGradeRepository.SelectByIdAsync(taskGradeForModificationTeacher.id);
        //validate
        taskGrade = taskGradeForModificationTeacher.Adapt(taskGrade);
        var updatedTaskGrade = await _taskGradeRepository.UpdateAsync(taskGrade);

        return updatedTaskGrade.Adapt<TaskGradeDTO>();
    }

    public async ValueTask<TaskGradeDTO> RemoveTaskGradeAsync(Guid taskGradeId)
    {
        var taskGrade = await _taskGradeRepository.SelectByIdAsync(taskGradeId);
        //validate
        var deletedTaskGrade = await _taskGradeRepository.DeleteAsync(taskGrade);

        return deletedTaskGrade.Adapt<TaskGradeDTO>();
    }

    public async ValueTask<TaskGradeDTO> RetrieveTaskGradeByIdAsync(Guid taskGradeId)
    {
        var taskGrade = await _taskGradeRepository.SelectByIdAsync(taskGradeId);
        //validate

        return taskGrade.Adapt<TaskGradeDTO>();
    }

    public IQueryable<TaskGradeDTO> RetrieveTaskGrades()
    {
        var taskGrades = _taskGradeRepository.SelectAll();

        return taskGrades.Select(taskGrade => taskGrade.Adapt<TaskGradeDTO>());
    }
}
