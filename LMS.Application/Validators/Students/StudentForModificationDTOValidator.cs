using FluentValidation;
using LMS.Application.DTOs;

namespace LMS.Application.Validators.Students;

public class StudentForModificationDTOValidator:AbstractValidator<StudentForModification>
{
    public StudentForModificationDTOValidator()
    {
        RuleFor(student => student)
           .NotNull()
           .WithMessage("Inalid data");

        RuleFor(student => student.fullName)
            .MaximumLength(50)
            .NotEmpty()
            .WithMessage("Invalid data");

        RuleFor(student => student.gender)
            .NotEmpty()
            .WithMessage("Invalid data");

        RuleFor(student => student.address)
            .NotEmpty()
            .WithMessage("Invalid data");

        RuleFor(student => student.groupId)
            .NotEmpty()
            .WithMessage("Invalid data");
    }
}
