namespace LMS.Application.DTOs;

public record NBForCreation(
    bool isAvailable,
    Guid lessonId,
    Guid studentId
    );
