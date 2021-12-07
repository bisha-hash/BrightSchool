namespace Domain.Entities;
public class ClassroomTeacher
{
    public int Id { get; set; }

    public int TeacherId { get; set; }
    public Teacher? Teacher { get; set; }

    public int ClassroomId { get; set; }
    public Classroom? Classroom { get; set; }
}