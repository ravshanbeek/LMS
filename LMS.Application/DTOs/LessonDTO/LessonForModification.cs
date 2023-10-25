namespace LMS.Application.DTOs;

public record LessonForModification(
    Guid id,
    string name,
    string lecture,
    DateTime date,
    Guid courseId,
    ICollection<Guid>? nbs
    );
