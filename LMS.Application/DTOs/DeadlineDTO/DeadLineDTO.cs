namespace LMS.Application.DTOs;

public record DeadLineDTO(
    float maxGrade,
    DateTime startDate,
    DateTime expiredDate,
    Guid courseId,
    ICollection<Guid>? grades
    );
