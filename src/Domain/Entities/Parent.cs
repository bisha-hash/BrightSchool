namespace Domain.Entities;
public class Parent
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }

    public List<StudentParent> StudentParents { get; set; } = new List<StudentParent>();
}