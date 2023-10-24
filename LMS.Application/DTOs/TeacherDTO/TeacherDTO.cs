using LMS.Domen.Entities;
using LMS.Domen.Enums;

namespace LMS.Application.DTOs;

public record TeacherDTO(
    Guid id,
    string fullName,
    DateTime birthdate,
    Gender gender,
    string address,
    string addressTemporary,
    string username,
    ICollection<Course>? courses
    );