using System;
using System.Collections.Generic;
using System.Linq;
using DepartmentManager.Models;

namespace DepartmentManager.Repository
{
    public class DepartmentRepository
    {
        private readonly Context context = new Context();

        public List<DbDepartment> GetAllDepartments()
        {
            return context.
                DbDepartments.
                ToList();
        }

        public DbDepartment GetDepartment(Guid id)
        {
            return context.
                DbDepartments.
                FirstOrDefault(d => d.ID == id);
        }

        public List<DbDepartment> GetSubDepartmens(Guid id)
        {
            return context.
                DbDepartments.
                Where(d => d.ParentDepartmentID == id).
                ToList();
        }
    }
}