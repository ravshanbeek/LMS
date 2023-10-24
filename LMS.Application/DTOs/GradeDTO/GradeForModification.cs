namespace LMS.Application.DTOs;

public record GradeForModification(
    float gradeValue,
    Guid dedlineId,
    Guid studentId
    );
