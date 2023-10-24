namespace LMS.Application.DTOs;

public record DeadlineForModification(
    Guid id,
    float maxGrade,
    DateTime startDate,
    Guid courseId,
    ICollection<Guid>? grades
    );
