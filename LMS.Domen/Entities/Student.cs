namespace LMS.Domen.Entities;

public class Student
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public Guid GroupId { get; set; }
    public Group Group { get; set; }
}
