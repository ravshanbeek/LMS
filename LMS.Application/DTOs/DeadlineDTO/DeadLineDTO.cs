namespace LMS.Application.DTOs;

public record DeadlineDTO(
    Guid id,
    float maxGrade,
    DateTime expiredDate,
    CourseDTO course,
    string filePath,
    ICollection<TaskGradeDTO> taskGrades
    );
