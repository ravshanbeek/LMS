namespace LMS.Application.DTOs;

public record NBForModification(
    Guid id,
    bool isAvailable,
    Guid lessonId,
    Guid studentId
    );
