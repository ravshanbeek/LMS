namespace LMS.Application.DTOs;

public record CourseDTO(
    Guid id,
    string name,
    SubjectDTO? subject,
    //TeacherDTO? teacher,
    ICollection<LessonDTO> lessons,
    ICollection<GroupDTO> groups,
    ICollection<DeadLineDTO> deadlines
    );
