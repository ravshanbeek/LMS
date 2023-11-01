using LMS.Application.DTOs;
using LMS.Domen.Entities;
using LMS.Infrastructure.Repositories;
using Mapster;

namespace LMS.Application.Services.Lessons;

public class LessonService : ILessonService
{
    private readonly ILessonRepository _lessonRepository;

    public LessonService(ILessonRepository lessonRepository)
        => _lessonRepository = lessonRepository;

    public async ValueTask<LessonDTO> CreateLessonAsync(LessonForCreation lessonForCreation)
    {
        var lesson = lessonForCreation.Adapt<Lesson>();
        var addedLesson = await _lessonRepository.InsertAsync(lesson);

        return addedLesson.Adapt<LessonDTO>();
    }

    public async ValueTask<LessonDTO> ModifyLessonAsync(LessonForModification lessonForModification)
    {
        var lesson = await _lessonRepository.SelectByIdAsync(lessonForModification.id);
        //validate
        lesson = lessonForModification.Adapt(lesson);

        return lesson.Adapt<LessonDTO>();
    }

    public async ValueTask<LessonDTO> RemoveLessonAsync(Guid lessonId)
    {
        var lesson = await _lessonRepository.SelectByIdAsync(lessonId);
        //validate
        var deletedLesson = await _lessonRepository.DeleteAsync(lesson);

        return deletedLesson.Adapt<LessonDTO>();
    }

    public async ValueTask<LessonDTO> RetrieveLessonByIdAsync(Guid lessonId)
    {
        var lesson = await _lessonRepository.SelectByIdAsync(lessonId);
        //validate

        return lesson.Adapt<LessonDTO>();
    }

    public IQueryable<LessonDTO> RetrieveLessons()
    {
        var lessons = _lessonRepository.SelectAll();

        return lessons.Select(lesson => lesson.Adapt<LessonDTO>());
    }
}
