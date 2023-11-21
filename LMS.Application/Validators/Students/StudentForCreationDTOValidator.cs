using FluentValidation;
using LMS.Application.DTOs;

namespace LMS.Application.Validators;

public class StudentForCreationDTOValidator: AbstractValidator<StudentForCreation>
{
    public StudentForCreationDTOValidator()
    {
        RuleFor(student => student)
            .NotNull()
            .WithMessage("Invalid data");

        RuleFor(student => student.fullName)
            .MaximumLength(50)
            .NotEmpty()
            .WithMessage("Invalid data");

        RuleFor(student => student.gender)
            .NotEmpty()
            .WithMessage("Invalid date")
            ;

        RuleFor(student => student.address) 
            .NotEmpty()
            .WithMessage("Invalid data");

        RuleFor(student => student.groupId)
            .NotEmpty()
            .WithMessage("Invalid date");
    }
}
