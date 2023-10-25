namespace LMS.Application.DTOs;

public record TaskGradeForModificationStudent(
    Guid id,
    Guid dedlineId,
    Guid studentId,
    string filePath
    );
