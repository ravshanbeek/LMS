namespace LMS.Application.DTOs;

public record DeadlineForCreation(
    float maxGrade,
    DateTime startDate,
    Guid courseId
    );
