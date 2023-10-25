namespace LMS.Application.DTOs;

public record DeadlineDTO(
    Guid id,
    float maxGrade,
    DateTime expiredDate,
    CourseDTO course,
    ICollection<TaskGradeDTO> taskGrades
    );
