namespace Domain.Entities;
public class Attendence
{
    public int Id { get; set; }

    public int StudentId { get; set; }
    public Student? Student { get; set; }

    public bool Status { get; set; }
    public string? Remark { get; set; }
}