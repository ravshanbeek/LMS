using LMS.Domen.Entities;

namespace LMS.Application.DTOs;

public record SubjectDTO(
    Guid id,
    string name,
    ICollection<CourseDTO>? courses
    );
