﻿namespace LMS.Application.DTOs;

public record SubjectForModification(
    Guid id,
    string name,
    ICollection<Guid>? courses
    );