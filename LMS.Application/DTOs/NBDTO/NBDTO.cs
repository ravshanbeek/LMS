namespace LMS.Application.DTOs;

public record NBDTO(
    Guid id,
    bool isAvailable,
    LessonDTO lesson,
    StudentDTO student
    );