using Microsoft.EntityFrameworkCore;
using MisProject.ApiService.Appointments;
using MisProject.ApiService.Diseases;
using MisProject.ApiService.Doctors;
using MisProject.ApiService.Patients;

namespace MisProject.ApiService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
