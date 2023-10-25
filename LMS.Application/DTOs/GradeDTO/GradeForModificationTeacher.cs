namespace LMS.Application.DTOs;

public record GradeForModificationTeacher(
    Guid id,
    float gradeValue,
    Guid dedlineId,
    Guid studentId
    );
