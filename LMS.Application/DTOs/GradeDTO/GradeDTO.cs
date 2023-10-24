namespace LMS.Application.DTOs;

public record GradeDTO(
    Guid id,
    float gradeValue,
    Guid dedlineId,
    Guid studentId
    );
