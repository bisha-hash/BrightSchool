namespace Domain.Entities;
public class Student
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }

    public int ClassroomId { get; set; }
    public Classroom? Classroom { get; set; }

    public List<StudentParent> StudentParents { get; set; } = new List<StudentParent>();
    public List<Grade> Grades { get; set; } = new List<Grade>();
}