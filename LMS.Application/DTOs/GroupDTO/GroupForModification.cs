using LMS.Domen.Entities;

namespace LMS.Application.DTOs;

public record GroupForModification(
    Guid id,
    string name,
    int level,
    ICollection<Student>? students,
    ICollection<Course>? courses
    );
