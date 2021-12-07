namespace Domain.Entities;
public class Classroom
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public List<ClassroomTeacher> ClassroomTeachers { get; set; } = new List<ClassroomTeacher>();
}
