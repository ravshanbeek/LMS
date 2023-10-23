namespace LMS.Application.DTOs;

public record CourseForModification(
    Guid id,
    string name,
    Guid teacherId,
    Guid subjectId,
    ICollection<Guid>? groups,
    ICollection<Guid>? lessons,
    ICollection<Guid>? deadline);
