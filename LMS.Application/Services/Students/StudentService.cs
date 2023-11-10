using LMS.Application.DTOs;
using LMS.Domen.Entities;
using LMS.Infrastructure.Repositories;
using Mapster;

namespace LMS.Application.Services.Students;

public partial class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
        => _studentRepository = studentRepository;

    public async ValueTask<StudentDTO> CreateStudentAsync(StudentForCreation studentForCreation)
    {
        ValidateStudentForCreationDTO(studentForCreation);

        var student = studentForCreation.Adapt<Student>();
        var addedStudent = await _studentRepository.InsertAsync(student);

        return addedStudent.Adapt<StudentDTO>();
    }

    public async ValueTask<StudentDTO> ModifyStudentAsync(StudentForModification studentForModification)
    {
        var student = await _studentRepository.SelectByIdAsync(studentForModification.id);
        ValidateStorageStudent(student);

        student = studentForModification.Adapt(student);
        var updatedStudent = await _studentRepository.UpdateAsync(student);

        return updatedStudent.Adapt<StudentDTO>();
    }

    public async ValueTask<StudentDTO> RemoveStudentAsync(Guid studentId)
    {
        var student = await _studentRepository.SelectByIdAsync(studentId);
        //validate
        var deletedStudent = await _studentRepository.DeleteAsync(student);

        return deletedStudent.Adapt<StudentDTO>();
    }

    public async ValueTask<StudentDTO> RetrieveStudentByIdAsync(Guid studentId)
    {
        var student = await _studentRepository.SelectByIdAsync(studentId);
        //validate

        return student.Adapt<StudentDTO>();
    }

    public IQueryable<StudentDTO> RetrieveStudents()
    {
        var students = _studentRepository.SelectAll();

        return students.Select(student => students.Adapt<StudentDTO>());
    }
}
