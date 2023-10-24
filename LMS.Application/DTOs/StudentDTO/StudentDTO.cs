using LMS.Domen.Enums;

namespace LMS.Application.DTOs;

public record StudentDTO(
    Guid id,
    string fullName,
    DateTime birthdate,
    Gender gender,
    string address,
    string addressTemporary,
    string username,
    Guid groupId
    );
