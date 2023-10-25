namespace LMS.Application.DTOs;

public record LessonDTO(
    Guid id,
    string name,
    string lecture,//aniqmas sal boshqacha bo'lishiyam mumkin
    DateTime date,
    CourseDTO course
    );
