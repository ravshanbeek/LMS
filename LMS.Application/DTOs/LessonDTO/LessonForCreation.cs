namespace LMS.Application.DTOs;

public record LessonForCreation(
    string name,
    string lecture,
    DateTime date,
    Guid courseId
    );
