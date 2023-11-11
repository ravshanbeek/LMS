using FluentValidation;
using LMS.Application.DTOs;
using System.Linq;

namespace LMS.Application.Validators.Students;

public class StudentForModificationDTOValidator:AbstractValidator<StudentForModification>
{
    public StudentForModificationDTOValidator()
    {
        RuleFor(student => student)
           .NotNull();

        RuleFor(student => student.fullName)
            .MaximumLength(50)
            .NotEmpty();

        RuleFor(student => student.gender)
            .NotEmpty();

        RuleFor(student => student.address)
            .NotEmpty();

        RuleFor(student => student.groupId)
            .NotEmpty();
    }
}
