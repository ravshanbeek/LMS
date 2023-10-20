namespace LMS.Domen.Entities;

public class Student
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public DateTime Birthdate { get; set; }
    public Gender? Gender { get; set; }
    public string Address { get; set; }
    public string AddressTemporary { get; set; }
    public Guid GroupId { get; set; }

    public Group? Group { get; set; }
}
