using LMS.Application.DTOs;
using LMS.Domen.Entities;
using LMS.Infrastructure.Repositories;
using Mapster;

namespace LMS.Application.Services.Teachers;

public class TeacherService : ITeacherService
{
    private readonly TeacherRepository _teacherRepository;

    public TeacherService(TeacherRepository teacherRepository) =>
        _teacherRepository = teacherRepository;

    public async ValueTask<TeacherDTO> CreateTeacherAsync(TeacherForCreation teacher)
    {
        var newTeacher = teacher.Adapt<Teacher>();
        var addedTeacher = await _teacherRepository.InsertAsync(newTeacher);

        return addedTeacher.Adapt<TeacherDTO>();
    }

    public async ValueTask<TeacherDTO> ModifyTeacherAsync(TeacherForModification teacherForModification)
    {
        var teacher = await _teacherRepository.SelectByIdAsync(teacherForModification.id);
        //validate
        teacher = teacherForModification.Adapt(teacher);
        var updatedTeacher = await _teacherRepository.UpdateAsync(teacher);

        return updatedTeacher.Adapt<TeacherDTO>();
    }

    public async ValueTask<TeacherDTO> RemoveTeacherAsync(Guid teacherId)
    {
        var teacher = await _teacherRepository.SelectByIdAsync(teacherId);
        //validate
        var deletedTeacher = await _teacherRepository.DeleteAsync(teacher);

        return deletedTeacher.Adapt<TeacherDTO>();
    }

    public async ValueTask<TeacherDTO> RetrieveTeacherByIdAsync(Guid teacherId)
    {
        var teacher = await _teacherRepository.SelectByIdAsync(teacherId);
        //validate

        return teacher.Adapt<TeacherDTO>();
    }

    public IQueryable<TeacherDTO> RetrieveTeachers()
    {
        var teachers = _teacherRepository.SelectAll();

        return teachers.Select(teacher => teacher.Adapt<TeacherDTO>());
    }
}
