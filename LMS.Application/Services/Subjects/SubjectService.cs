using LMS.Application.DTOs;
using LMS.Infrastructure.Repositories;

namespace LMS.Application.Services.Subjects
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;
        private readonly ISubjectFactory _subjectFactory;

        public SubjectService(
            ISubjectRepository subjectRepository, 
            ISubjectFactory subjectFactory)
        {
            _subjectRepository = subjectRepository;
            _subjectFactory = subjectFactory;
        }

        public async ValueTask<SubjectDTO> CreateSubjectAsync(SubjectForCreation subject)
        {
            var newSubject = _subjectFactory.MapToSubject(subject);
            var addedSubject = await _subjectRepository.InsertAsync(newSubject);

            return  _subjectFactory.MapToSubjectDTO(addedSubject);
        }

        public async ValueTask<SubjectDTO> ModifySubjectAsync(SubjectForModification subjectForModification)
        {
            var storageSubject = await _subjectRepository.SelectByIdAsync(subjectForModification.id);
            //validate
            _subjectFactory.MapToSubject(storageSubject, subjectForModification);
            var updatedSubject = await _subjectRepository.UpdateAsync(storageSubject);

            return _subjectFactory.MapToSubjectDTO(updatedSubject);
        }

        public async ValueTask<SubjectDTO> RemoveSubjectAsync(Guid subjectId)
        {
            var storageSubject = await _subjectRepository.SelectByIdAsync(subjectId);
            //validate
            var deletedSubject = await _subjectRepository.DeleteAsync(storageSubject);

            return _subjectFactory.MapToSubjectDTO(deletedSubject);
        }

        public async ValueTask<SubjectDTO> RetrieveSubjectByIdAsync(Guid subjectId)
        {
            var storageSubject = await _subjectRepository.SelectByIdAsync(subjectId);
            //validate

            return _subjectFactory.MapToSubjectDTO(storageSubject);
        }

        public IQueryable<SubjectDTO> RetrieveSubjects()
        {
            var subjects = _subjectRepository.SelectAll();
            //validate

            return subjects.Select(subject => _subjectFactory.MapToSubjectDTO(subject));
        }
    }
}
