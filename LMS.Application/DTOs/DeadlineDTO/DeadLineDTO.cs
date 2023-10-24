namespace LMS.Application.DTOs;

public record DeadLineDTO(
    Guid id,
    float maxGrade,
    DateTime startDate,
    DateTime expiredDate,
    Guid courseId,
    ICollection<Guid>? grades
    );
