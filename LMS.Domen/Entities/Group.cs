namespace LMS.Domen.Entities;

public class Group : Auditable
{
    public string Name { get; set; }
    public int Level { get; set; }

    public ICollection<Student>? Students { get; set; }
    public ICollection<Course>? Courses { get; set; }
}
