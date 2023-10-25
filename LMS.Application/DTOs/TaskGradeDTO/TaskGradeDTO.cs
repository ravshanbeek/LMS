namespace LMS.Application.DTOs;

public record TaskGradeDTO(
    Guid id,
    float gradeValue,
    string filePath,
    DeadlineDTO dedline,
    StudentDTO student,
    bool isUploaded,
    bool isRated
    );
