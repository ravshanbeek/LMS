namespace LMS.Domen.Entities
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Course>? Courses { get; set; }
    }
}
