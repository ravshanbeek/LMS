namespace LMS.Application.DTOs;

public record LessonForCreation(
    string name,
    string lecture,//aniqmas sal boshqacha bo'lishiyam mumkin
    DateTime date,
    Guid courseId
    );
