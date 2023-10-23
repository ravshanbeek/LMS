using System.Text.RegularExpressions;

namespace LMS.Domen.Entities
{
    public class Course : Auditable
    {
        public string Name { get; set; }
        public Guid TeacherId {  get; set; }
        public Guid SubjectId { get; set; }

        public Teacher? Teacher { get; set;}
        public Subject? Subject { get; set; }
        public ICollection<Lesson>? Lessons { get; set; }
        public ICollection<Deadline>? Deadlines { get; set; }
        public ICollection<Group>? Groups { get; set; }
    }
}
