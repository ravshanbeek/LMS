namespace LMS.Domen.Entities
{
    public class Grade : Auditable
    {
        public float GradeValue { get; set; }
        public Guid DedlineId { get; set; }
        public Guid StudentId { get; set; }

        public Deadline? Deadline { get; set; }
        public Student? Student { get; set; }
    }
}
