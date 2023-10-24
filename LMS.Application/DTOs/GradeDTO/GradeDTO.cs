namespace LMS.Application.DTOs;

public record GradeDTO(
    float gradeValue,
    Guid dedlineId,
    Guid studentId
    );
