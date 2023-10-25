namespace LMS.Application.DTOs;

public record LessonDTO(
    Guid id,
    string name,
    string lecture,
    DateTime date,
    CourseDTO course,
    ICollection<NBDTO> nbs
    );
