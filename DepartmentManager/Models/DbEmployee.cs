using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentManager.Models
{
    [Table("Empoyee")]
    public class DbEmployee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public DbDepartment Department { get; set; }

        [ForeignKey("Department")]
        public Guid DepartmentID {get;set;}

        [MaxLength(50)]
        public string SurName { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string Patronymic { get; set; }

        public DateTime DateOfBirth { get; set; }

        [MaxLength(4)]
        public string DocSeries { get; set; }

        [MaxLength(6)]
        public string DocNumber { get; set; }

        [MaxLength(50)]

        public string Position { get; set; }                
    }
}
