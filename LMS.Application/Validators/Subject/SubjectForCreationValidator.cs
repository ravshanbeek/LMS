using FluentValidation;
using LMS.Application.DTOs;

namespace LMS.Application.Validators.Subject
{
    public class SubjectForCreationValidator : AbstractValidator<SubjectForCreation>
    {
        public SubjectForCreationValidator()
        {
            RuleFor(x => x.name)
                .MaximumLength(50)
                .NotEmpty();
        }
    }
}
