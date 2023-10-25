using LMS.Domen.Entities;
using LMS.Domen.Enums;

namespace LMS.Application.DTOs;

public record TeacherForCreation(
    string fullName ,
    DateTime birthdate ,
    Gender gender ,
    string address ,
    string addressTemporary ,
    string username
    );
