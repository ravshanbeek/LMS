using FluentValidation;
using FluentValidation.Results;
using LMS.Application.DTOs;
using LMS.Application.Validators;
using LMS.Domen.Entities;
using LMS.Domen.Exceptions;
using System.Text.Json;

namespace LMS.Application.Services.Students
{
    public partial class StudentService
    {
        private void ValidateStudentForCreationDTO(StudentForCreation studentForCreation)
        {
            StudentForCreationDTOValidator validator = new StudentForCreationDTOValidator();

            var validateResult = validator.Validate(studentForCreation);

            ThrowValidationExceptionIfValidationIsInvalid(validateResult);
        }

        private void ValidateStorageStudent(Student student)
        {
            if(student == null)
            {
                throw new NotFoundException("Student not found");
            }
        }

        private void ThrowValidationExceptionIfValidationIsInvalid(ValidationResult validateResult)
        {
            if(validateResult.IsValid)
            {
                return;
            }
            var errors = JsonSerializer
                .Serialize(validateResult.Errors.Select(error => new
                {
                    PropertyName = error.PropertyName,
                    ErrorMessage = error.ErrorMessage,
                    AttemptedValue = error.AttemptedValue
                }));

            throw new Domen.Exceptions.ValidationException(errors);
        }
    }
}
