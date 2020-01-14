using System.Data.Entity;

namespace DepartmentManager.Models
{
    public class Context : DbContext
    {
        public Context() : base("Department")
        {

        }

        public DbSet<DbDepartment> DbDepartments { get; set; }

        public DbSet<DbEmployee> DbEmployees { get; set; }
    }
}
