﻿using FluentValidation;
using LMS.Application.DTOs;

namespace LMS.Application.Validators;

public class StudentForCreationDTOValidator: AbstractValidator<StudentForCreation>
{
    public StudentForCreationDTOValidator()
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
