namespace LMS.Application.DTOs;

public record NBDTO(
    Guid id,
    bool isAvailable,
    Guid lessonId,
    Guid studentId
    );