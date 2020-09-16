
using E_Healthcare.Data;
using Microsoft.EntityFrameworkCore;

namespace E_Healthcare.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=RSC-PC\\SQLEXPRESS;Initial Catalog=E-Heathcare;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
