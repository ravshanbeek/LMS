namespace LMS.Application.DTOs;

public record GradeForCreation(
    float gradeValue,
    Guid dedlineId,
    Guid studentId
    );
