using LMS.Domen.Entities;

namespace LMS.Application.DTOs;

public record GroupDTO(
    string name,
    int level,
    ICollection<Student>? students,
    ICollection<Course>? courses
    );
