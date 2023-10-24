using LMS.Domen.Entities;

namespace LMS.Application.DTOs;

public record SubjectForModification(
    Guid id,
    string name,
    ICollection<Course>? courses
    );