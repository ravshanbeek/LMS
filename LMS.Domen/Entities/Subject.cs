namespace LMS.Domen.Entities
{
    public class Subject : Auditable
    {
        public string Name { get; set; }

        public ICollection<Course>? Courses { get; set; }
    }
}
