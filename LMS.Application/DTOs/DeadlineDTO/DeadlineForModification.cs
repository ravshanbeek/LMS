namespace LMS.Application.DTOs;

public record DeadlineForModification(
    float maxGrade,
    DateTime startDate,
    Guid courseId,
    ICollection<Guid>? grades
    );
