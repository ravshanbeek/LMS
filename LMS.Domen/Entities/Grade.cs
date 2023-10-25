namespace LMS.Domen.Entities
{
    public class Grade : Auditable
    {
        public float GradeValue { get; set; }
        public Guid DedlineId { get; set; }
        public Guid StudentId { get; set; }
        public string FilePath { get; set; }
        public bool IsUploaded { get; set; }
        public bool IsRated { get; set; }

        public Deadline? Deadline { get; set; }
        public Student? Student { get; set; }
    }
}
