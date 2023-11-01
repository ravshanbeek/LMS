using LMS.Application.DTOs;

namespace LMS.Application.Services.Lessons;

public interface ILessonService
{
    ValueTask<LessonDTO> CreateLessonAsync(LessonForCreation lessonForCreation);
    IQueryable<LessonDTO> RetrieveLessons();
    ValueTask<LessonDTO> RetrieveLessonByIdAsync(Guid lessonId);
    ValueTask<LessonDTO> ModifyLessonAsync(LessonForModification lessonForModification);
    ValueTask<LessonDTO> RemoveLessonAsync(Guid lessonId);
}
