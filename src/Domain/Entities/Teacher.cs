namespace Domain.Entities;
public class Teacher
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }

    public List<ClassroomTeacher> ClassroomTeachers { get; set; } = new List<ClassroomTeacher>();
}