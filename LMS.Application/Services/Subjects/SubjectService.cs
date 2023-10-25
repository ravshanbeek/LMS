using LMS.Application.DTOs;
using LMS.Domen.Entities;
using LMS.Infrastructure.Repositories;

namespace LMS.Application.Services.Subjects
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectService(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public async ValueTask<SubjectDTO> CreateSubjectAsync(SubjectForCreation subject)
        {
            var addedSubject = await _subjectRepository.InsertAsync(
                new Subject {
                    Name = subject.name,
                });

            return new SubjectDTO(
                addedSubject.Id,
                addedSubject.Name,
                null//addedSubject.Courses
            );
        }

        public async ValueTask<SubjectDTO> ModifySubjectAsync(SubjectForModification subjectForModification)
        {
            var storageSubject = await _subjectRepository.SelectByIdAsync(subjectForModification.id);

            var updatedSubject = await _subjectRepository.UpdateAsync(new Subject
            {
                Id = subjectForModification.id,
                Name = subjectForModification.name,
                Courses = null,// subjectForModification.courses
                UpdatedAt = DateTime.Now
            });

            return new SubjectDTO(
                updatedSubject.Id,
                updatedSubject.Name,
                null//updatedSubject.Courses
                );
        }

        public async ValueTask<SubjectDTO> RemoveSubjectAsync(Guid subjectId)
        {
            var storageSubject = await _subjectRepository.SelectByIdAsync(subjectId);

            var deletedSubject = await _subjectRepository.DeleteAsync(storageSubject);

            return new SubjectDTO(
                deletedSubject.Id,
                deletedSubject.Name,
                null//deletedSubject.Courses
                );
        }

        public async ValueTask<SubjectDTO> RetrieveSubjectByIdAsync(Guid subjectId)
        {
            var storageSubject = await _subjectRepository.SelectByIdAsync(subjectId);

            return new SubjectDTO(
                storageSubject.Id,
                storageSubject.Name,
                null//storageSubject.Courses
                );
        }

        public IQueryable<SubjectDTO> RetrieveSubjects()
        {
            var subjects = _subjectRepository.SelectAll();

            return subjects.Select(subject => new SubjectDTO(
                subject.Id,
                subject.Name,
                null//subject.Courses
                ));
        }
    }
}
