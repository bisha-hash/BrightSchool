namespace Domain.Entities;
public class Grade
{
    public int Id { get; set; }

    public int StudentId { get; set; }
    public Student? Student { get; set; }
    
    public int CourseId { get; set; }
    public Course? Course { get; set; }

    public string? Mark { get; set; }

    public string? Description { get; set; }
}