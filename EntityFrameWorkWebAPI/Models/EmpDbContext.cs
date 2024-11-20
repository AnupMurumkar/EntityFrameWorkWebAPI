using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkWebAPI.Models
{
    public class EmpDbContext :DbContext
    {
      public EmpDbContext() { }
    public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee() {EmployeeId = 1, EmployeeName = "Anup", EmployeeEmail = "anup@gmail.com", EmployeePhone = "2233445" },
                new Employee() { EmployeeId = 2,EmployeeName = "Ayush", EmployeeEmail = "Ayush@gmail.com", EmployeePhone = "3344556" }
                );
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
        
    }
}
