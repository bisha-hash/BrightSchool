using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;
public interface IApplicationDbContext
{
    DbSet<Attendence>? Attendences { get; }
    DbSet<Class>? Classes { get; }
    DbSet<Classroom>? Classrooms { get; }
    DbSet<ClassroomTeacher>? ClassroomsTeachers { get; }
    DbSet<Course>? Courses { get; }
    DbSet<Grade>? Grades { get; }
    DbSet<Parent>? Parents { get; }
    DbSet<Student>? Students { get; }
    DbSet<StudentParent>? StudentParents { get; }
    DbSet<Teacher>? Teachers { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}