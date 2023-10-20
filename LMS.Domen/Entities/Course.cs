namespace LMS.Domen.Entities
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid TeacherId {  get; set; }
        public Guid SubjectId { get; set; }

        public Teacher? Teacher { get; set;}
        public Subject? Subject { get; set; }
        public ICollection<Lesson>? Lessons { get; set; }
    }
}
