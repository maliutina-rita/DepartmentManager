using DepartmentManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DepartmentManager.Repository
{
    public class DepartmentRepository
    {
        Context context = new Context();

        public List<DbDepartment> GetAllDepartments()
        {
            var departments = context.DbDepartments.ToList();

            return departments;
        }

        public DbDepartment GetDepartment(Guid id)
        {
            var code = context.DbDepartments.FirstOrDefault(d => d.ID == id);
            return code;
        }

        public List<DbDepartment> GetSubDepartmens(Guid id)
        {
            var departments = context.DbDepartments.Where(d => d.ParentDepartmentID == id).ToList();
            return departments;
        }
    }
}