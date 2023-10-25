using LMS.Application.DTOs;
using LMS.Domen.Entities;

namespace LMS.Application.Services.Subjects;

public class SubjectFactory : ISubjectFactory
{
    public Subject MapToSubject(SubjectForCreation subjectForCreation)
    {
        return new Subject
        {
            Name = subjectForCreation.name
        };
    }

    public void MapToSubject(Subject subject, SubjectForModification subjectForModification)
    {
        subject.Id = subjectForModification.id;
        subject.Name = subjectForModification.name;
        subject.Courses = null;//subjectForModification.courses;
    }

    public SubjectDTO MapToSubjectDTO(Subject subject)
    {
        return new SubjectDTO(
            subject.Id,
            subject.Name,
            null//subject.Courses;
            );
    }
}
