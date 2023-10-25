namespace LMS.Domen.Entities
{
    public class Deadline : Auditable
    {
        public float MaxGrade { get; set; }
        public DateTime ExpiredDate { get; set; }
        public string FilePath { get; set; }
        public Guid CourseId { get; set; }

        public Course? Course { get; set; }
        public ICollection<TaskGrade>? TaskGrades { get; set; }
    }
}
