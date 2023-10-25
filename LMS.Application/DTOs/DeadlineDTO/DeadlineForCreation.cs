namespace LMS.Application.DTOs;

public record DeadlineForCreation(
    float maxGrade,
    DateTime expiredDate,
    string filePath,
    Guid courseId
    );
