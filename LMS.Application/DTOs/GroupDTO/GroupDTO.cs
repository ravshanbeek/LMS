using LMS.Domen.Entities;

namespace LMS.Application.DTOs;

public record GroupDTO(
    Guid id,
    string name,
    int level,
    ICollection<StudentDTO>? students,
    ICollection<CourseDTO>? courses
    );
