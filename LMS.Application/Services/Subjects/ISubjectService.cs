using LMS.Application.DTOs;

namespace LMS.Application.Services.Subjects;

public interface ISubjectService
{
    ValueTask<SubjectDTO> CreateSubjectAsync(SubjectForCreation subject);
    IQueryable<SubjectDTO> RetrieveSubjects();
    ValueTask<SubjectDTO> RetrieveSubjectByIdAsync(Guid subjectId);
    ValueTask<SubjectDTO> ModifySubjectAsync(SubjectForModification subjectForModification);
    ValueTask<SubjectDTO> RemoveSubjectAsync(Guid subjectId);
}
