namespace LMS.Application.DTOs;

public record GradeDTO(
    Guid id,
    float gradeValue,
    DeadlineDTO dedline,
    StudentDTO student,
    bool isUploaded,
    bool isRated
    );
