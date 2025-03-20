namespace PatientService.Data;

using Microsoft.EntityFrameworkCore;
using PatientService.Models; 

public class PatientDbContext : DbContext
{
    public PatientDbContext(DbContextOptions<PatientDbContext> options) : base(options) { }

    public DbSet<Patient> Patients { get; set; }
}