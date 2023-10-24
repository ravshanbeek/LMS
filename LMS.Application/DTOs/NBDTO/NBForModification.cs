namespace LMS.Application.DTOs;

public record NBForModification(
    bool isAvailable,
    Guid lessonId,
    Guid studentId
    );
