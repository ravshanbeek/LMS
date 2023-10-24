namespace LMS.Application.DTOs;

public record LessonForModification(
    Guid id,
    string name,
    string lecture,//aniqmas sal boshqacha bo'lishiyam mumkin
    DateTime date,
    Guid courseId
    );
