using LMS.Domen.Enums;

namespace LMS.Domen.Entities;

public class Student : Auditable
{
    public string FullName { get; set; }
    public DateTime Birthdate { get; set; }
    public Gender Gender { get; set; }
    public string Address { get; set; }
    public string AddressTemporary { get; set; }
    public string Username { get; set; }
    public string Salt { get; set; }
    public string HashedPassword { get; set; }

    public Guid GroupId { get; set; }
    public Group? Group { get; set; }
}
x