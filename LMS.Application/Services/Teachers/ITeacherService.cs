using LMS.Application.DTOs;

namespace LMS.Application.Services.Teachers;

public interface ITeacherService
{
    ValueTask<TeacherDTO> CreateTeacherAsync(TeacherForCreation teacher);
    IQueryable<TeacherDTO> RetrieveTeachers();
    ValueTask<TeacherDTO> RetrieveTeacherByIdAsync(Guid teacherId);
    ValueTask<TeacherDTO> ModifyTeacherAsync(TeacherForModification teacherForModification);
    ValueTask<TeacherDTO> RemoveTeacherAsync(Guid teacherId);
}
