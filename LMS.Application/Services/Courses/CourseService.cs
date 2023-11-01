using LMS.Application.DTOs;
using LMS.Domen.Entities;
using LMS.Infrastructure.Repositories;
using Mapster;

namespace LMS.Application.Services.Courses;

public class CourseService : ICourseService
{
    private readonly ICourseRepository _courseRepository;

    public CourseService(ICourseRepository courseRepository)
        => _courseRepository = courseRepository;

    public async ValueTask<CourseDTO> CreateCourseAsync(CourseForCreation courseForCreation)
    {
        var course = courseForCreation.Adapt<Course>();
        var addedCourse = await _courseRepository.InsertAsync(course);

        return addedCourse.Adapt<CourseDTO>();
    }

    public async ValueTask<CourseDTO> ModifyCourseAsync(CourseForModification courseForModification)
    {
        var course = await _courseRepository.SelectByIdAsync(courseForModification.id);
        //validate
        course = courseForModification.Adapt(course);
        var updatedCourse = await _courseRepository.UpdateAsync(course);

        return updatedCourse.Adapt<CourseDTO>();
    }

    public async ValueTask<CourseDTO> RemoveCourseAsync(Guid courseId)
    {
        var course = await _courseRepository.SelectByIdAsync(courseId);
        //validate
        var deletedCourse = await _courseRepository.DeleteAsync(course);

        return deletedCourse.Adapt<CourseDTO>();
    }

    public async ValueTask<CourseDTO> RetrieveCourseByIdAsync(Guid courseId)
    {
        var course = await _courseRepository.SelectByIdAsync(courseId);
        //validate

        return course.Adapt<CourseDTO>();
    }

    public IQueryable<CourseDTO> RetrieveCourses()
    {
        var courses = _courseRepository.SelectAll();

        return courses.Select(c => c.Adapt<CourseDTO>());
    }
}
