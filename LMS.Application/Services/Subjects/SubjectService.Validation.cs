using FluentValidation.Results;
using LMS.Application.DTOs;
using LMS.Application.Validators.Subject;
using LMS.Domen.Entities;
using LMS.Domen.Exceptions;
using System.Text.Json;

namespace LMS.Application.Services.Subjects
{
    public partial class SubjectService
    {
        private void ValidateSubjectForCreationDTO(SubjectForCreation subjectForCreation)
        {
            SubjectForCreationValidator validator = new SubjectForCreationValidator();
            var validationResult = validator.Validate(subjectForCreation);

            ThrowIfValidationIsInvalidAsync(validationResult);
        }

        private void ValidateSubjectForModificationDTO(SubjectForModification subjectForModification)
        {
            SubjectForModificationValidator validator = new SubjectForModificationValidator();
            var validationResult = validator.Validate(subjectForModification);

            ThrowIfValidationIsInvalidAsync(validationResult);
        }

        private void ValidateStorageSubject(Subject subject)
        {
            if (subject == null)
            {
                throw new NotFoundException("Subject not found");
            }
        }

        private void ThrowIfValidationIsInvalidAsync(ValidationResult validationResult)
        {
            if (validationResult.IsValid)
            {
                return;
            }

            var message = JsonSerializer.Serialize(validationResult.Errors.Select(errors => new
            {
                PropertyName = errors.PropertyName,
                ErrorMessage = errors.ErrorMessage,
                EttemptedValue = errors.AttemptedValue
            }));

            throw new ValidationException(message);
        }
    }
}
