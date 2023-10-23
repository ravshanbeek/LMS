namespace LMS.Application.DTOs;

public record CourseForCreation(
    string name,
    Guid teacherId,
    Guid subjectId);
