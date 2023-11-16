using FluentValidation;
using LMS.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
