using FluentValidation;
using LMS.Application.DTOs;

namespace LMS.Application.Validators;

public class StudentForCreationDTOValidator: AbstractValidator<StudentForCreation>
{
    public StudentForCreationDTOValidator()
    {
        
    }
}
