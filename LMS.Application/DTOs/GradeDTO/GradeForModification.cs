namespace LMS.Application.DTOs;

public record GradeForModification(
    Guid id,
    float gradeValue,
    Guid dedlineId,
    Guid studentId
    );
