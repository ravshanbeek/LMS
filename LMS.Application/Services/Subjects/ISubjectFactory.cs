using LMS.Application.DTOs;
using LMS.Domen.Entities;

namespace LMS.Application.Services.Subjects;

public interface ISubjectFactory
{
    SubjectDTO MapToSubjectDTO(Subject subject);
    Subject MapToSubject(SubjectForCreation subjectForCreation);
    void MapToSubject(Subject subject,SubjectForModification subjectForModification);
}
