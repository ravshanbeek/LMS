using LMS.Application.DTOs;

namespace LMS.Application.Services.Courses;

public interface ICourseService
{
    ValueTask<CourseDTO> CreateCourseAsync(CourseForCreation courseForCreation);
    IQueryable<CourseDTO> RetrieveCourses();
    ValueTask<CourseDTO> RetrieveCourseByIdAsync(Guid courseId);
    ValueTask<CourseDTO> ModifyCourseAsync(CourseForModification courseForModification);
    ValueTask<CourseDTO> RemoveCourseAsync(Guid courseId);
}
