using LMS.Application.DTOs;

namespace LMS.Application.Services.Students;

public interface IStudentService
{
    ValueTask<StudentDTO> CreateStudentAsync(StudentForCreation studentForCreation);
    IQueryable<StudentDTO> RetrieveStudents();
    ValueTask<StudentDTO> RetrieveStudentByIdAsync(Guid studentId);
    ValueTask<StudentDTO> ModifyStudentAsync(StudentForModification studentForModification);
    ValueTask<StudentDTO> RemoveStudentAsync(Guid studentId);
}
