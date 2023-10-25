namespace LMS.Application.DTOs;

public record TaskGradeForModificationTeacher(
    Guid id,
    float gradeValue,
    string filePath,
    Guid dedlineId,
    Guid studentId,
    bool isUploaded,
    bool isRated
    );
