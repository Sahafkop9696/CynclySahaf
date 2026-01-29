using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrainingManagement.API.Models;

namespace TrainingManagement.API.Data;

public class TrainingManagementDbContext : IdentityDbContext<ApplicationUser>
{
    public TrainingManagementDbContext(DbContextOptions<TrainingManagementDbContext> options)
        : base(options)
    {
    }

    public DbSet<Batch> Batches { get; set; }
    public DbSet<BatchDetail> BatchDetails { get; set; }
    public DbSet<College> Colleges { get; set; }
    public DbSet<Evaluation> Evaluations { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<FacultySubject> FacultiesSubjects { get; set; }
    public DbSet<FeesDetail> FeesDetails { get; set; }
    public DbSet<Resource> Resources { get; set; }
    public DbSet<ResourceType> ResourceTypes { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Trainee> Trainees { get; set; }
    public DbSet<TraineeAssignment> TraineeAssignments { get; set; }
    public DbSet<TraineeEvaluation> TraineeEvaluations { get; set; }
}
