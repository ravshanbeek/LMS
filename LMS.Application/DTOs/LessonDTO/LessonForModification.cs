namespace LMS.Application.DTOs;

public record LessonForModification(
    string name,
    string lecture,//aniqmas sal boshqacha bo'lishiyam mumkin
    DateTime date,
    Guid courseId
    );
