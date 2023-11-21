using FluentValidation;
using LMS.Application.DTOs;

namespace LMS.Application.Validators.Subject
{
    internal class SubjectForModificationValidator : AbstractValidator<SubjectForModification>
    {
        public SubjectForModificationValidator()
        {
            RuleFor(x => x)
                .NotEmpty()
                .WithMessage("Invalid data");

            RuleFor(x => x.name)
                .NotEmpty()
                .WithMessage("Invalid data");

        }
    }
}
