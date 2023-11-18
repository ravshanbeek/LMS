using LMS.Application.DTOs;
using LMS.Domen.Entities;
using LMS.Infrastructure.Repositories;
using Mapster;

namespace LMS.Application.Services.Subjects
{
    public partial class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectService(ISubjectRepository subjectRepository)
            => _subjectRepository = subjectRepository;

        public async ValueTask<SubjectDTO> CreateSubjectAsync(SubjectForCreation subjectForCreation)
        {
            ValidateSubjectForCreationDTO(subjectForCreation);

            var newSubject = subjectForCreation.Adapt<Subject>();
            var addedSubject = await _subjectRepository.InsertAsync(newSubject);

            return addedSubject.Adapt<SubjectDTO>();
        }

        public async ValueTask<SubjectDTO> ModifySubjectAsync(SubjectForModification subjectForModification)
        {
            ValidateSubjectForModificationDTO(subjectForModification);
            var storageSubject = await _subjectRepository.SelectByIdAsync(subjectForModification.id);

            storageSubject = subjectForModification.Adapt(storageSubject);
            var updatedSubject = await _subjectRepository.UpdateAsync(storageSubject);

            return updatedSubject.Adapt<SubjectDTO>();
        }

        public async ValueTask<SubjectDTO> RemoveSubjectAsync(Guid subjectId)
        {
            var storageSubject = await _subjectRepository.SelectByIdAsync(subjectId);
            //validate
            var deletedSubject = await _subjectRepository.DeleteAsync(storageSubject);

            return deletedSubject.Adapt<SubjectDTO>();
        }

        public async ValueTask<SubjectDTO> RetrieveSubjectByIdAsync(Guid subjectId)
        {
            var storageSubject = await _subjectRepository.SelectByIdAsync(subjectId);
            //validate

            return storageSubject.Adapt<SubjectDTO>();
        }

        public IQueryable<SubjectDTO> RetrieveSubjects()
        {
            var subjects = _subjectRepository.SelectAll();
            //validate

            return subjects.Select(subject => subject.Adapt<SubjectDTO>());
        }
    }
}
