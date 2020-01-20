using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentManager.Models
{
    [Table("Department")]
    public class DbDepartment
    {
        [Key]
        public Guid ID { get; set; }

        public DbDepartment Department { get; set;  }

        [ForeignKey("Department")]
        public Guid? ParentDepartmentID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(10)]
        public string Code { get; set; }

        public virtual ICollection<DbDepartment> SubDepartments { get; set; }
    }
}