namespace LMS.Domen.Entities
{
    public class Lesson : Auditable
    {
        public string Name { get; set; }
        public string Lecture { get; set; }
        public DateTime Date { get; set; }
        public Guid CourseId { get; set; }

        public Course? Course { get; set; }
        public ICollection<NB>? NBs { get; set; }
    }
}
