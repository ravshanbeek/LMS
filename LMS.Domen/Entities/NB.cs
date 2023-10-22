namespace LMS.Domen.Entities
{
    public class NB
    {
        public Guid Id { get; set; }
        public bool IsAvailable { get; set; }
        public Guid LessonId { get; set; }
        public Guid StudentId { get; set; }

        public Lesson? Lesson { get; set; }
        public Student? Student { get; set; }
    }
}
