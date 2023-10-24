using LMS.Domen.Enums;

namespace LMS.Application.DTOs;

public record StudentForCreation(
    string fullName,
    DateTime birthdate,
    Gender gender, 
    string address,
    string addressTemporary,
    string username,
    //string salt, // balki xatodur
    //string hashedPassword,
    Guid groupId
    );
