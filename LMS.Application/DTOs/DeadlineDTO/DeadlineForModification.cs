namespace LMS.Application.DTOs;

public record DeadlineForModification(
    Guid id,
    float maxGrade,
    DateTime expiredDate,
    Guid courseId,
    string filePath,
    ICollection<Guid>? tasks
    );
