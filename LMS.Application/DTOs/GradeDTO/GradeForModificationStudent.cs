namespace LMS.Application.DTOs;

public record GradeForModificationStudent(
    Guid id,
    Guid dedlineId,
    Guid studentId,
    string filePath
    );
