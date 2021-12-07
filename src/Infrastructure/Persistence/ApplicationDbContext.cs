using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;
public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    public DbSet<Attendence>? Attendences => Set<Attendence>();
    public DbSet<Class>? Classes => Set<Class>();
    public DbSet<Classroom>? Classrooms => Set<Classroom>();
    public DbSet<ClassroomTeacher>? ClassroomsTeachers => Set<ClassroomTeacher>();
    public DbSet<Course>? Courses => Set<Course>();
    public DbSet<Grade>? Grades => Set<Grade>();
    public DbSet<Parent>? Parents => Set<Parent>();
    public DbSet<Student>? Students => Set<Student>();
    public DbSet<StudentParent>? StudentParents => Set<StudentParent>();
    public DbSet<Teacher>? Teachers => Set<Teacher>();

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var result = await base.SaveChangesAsync(cancellationToken);

        return result;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClassroomTeacher>()
            .HasOne(cr => cr.Classroom)
            .WithMany(crt => crt.ClassroomTeachers)
            .HasForeignKey(cri => cri.ClassroomId);

        modelBuilder.Entity<ClassroomTeacher>()
            .HasOne(ct => ct.Teacher)
            .WithMany(crt => crt.ClassroomTeachers)
            .HasForeignKey(cti => cti.TeacherId);
    }
}