namespace LMS.Application.DTOs;

public record DeadlineForModification(
    Guid id,
    float maxGrade,
    DateTime expiredDate,
    Guid courseId
    );
