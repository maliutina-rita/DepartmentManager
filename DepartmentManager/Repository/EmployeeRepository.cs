using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DepartmentManager.Models;

namespace DepartmentManager.Repository
{
    public class EmployeeRepository
    {
        private readonly Context context = new Context();

        public DbEmployee GetEmployee(decimal id)
        {
            return context
                .DbEmployees
                .Include(i => i.Department)
                .FirstOrDefault(d => d.ID == id);
        }

        public List<DbEmployee> GetDepartmentEmployee(Guid departamentId)
        {
            return context.DbEmployees.Where(e => e.DepartmentID == departamentId).ToList();
        }

        public void AddEmployee(string surName, string firstName, string patronymic, DateTime dateOfBirth, string docSeries, 
            string docNumber, string Position, DbDepartment currentDep)
        {
            var employee = new DbEmployee();          
           
            employee.DepartmentID = currentDep.ID;
            employee.SurName = surName;
            employee.FirstName = firstName;
            employee.DateOfBirth = dateOfBirth;
            employee.Position = Position;

            if (String.IsNullOrEmpty(patronymic))
            {
                employee.Patronymic = patronymic;
            }
            
            if(String.IsNullOrEmpty(docSeries))
            {
                employee.DocSeries = docSeries;
            }

            if(String.IsNullOrEmpty(docNumber))
            {
                employee.DocNumber = docNumber;
            }
            context.DbEmployees.Add(employee);
            context.SaveChanges();
        }

        public void EditEmployee(decimal id, string surName, string firstName, string patronymic, DateTime dateOfBirth,
            string docSeries, string docNumber, string position, string currentDepartment)
        {
            var employee = context.
                DbEmployees.
                FirstOrDefault(d => d.ID == id) ?? throw new ArgumentException("Incorrect ID");

            employee.SurName = surName;
            employee.FirstName = firstName;
            employee.Patronymic = patronymic;
            employee.DateOfBirth = dateOfBirth;
            employee.DocSeries = docSeries;
            employee.DocNumber = docNumber;
            employee.Position = position;

            var department = context
                .DbDepartments
                .FirstOrDefault(d => d.Name == currentDepartment);

            if (department != null)
            {
                employee.Department = department;
            }
            context.SaveChanges();
        }

        public List<DbEmployee> SearchEmployee(string search)
        {
             return context
                .DbEmployees
                .Where(d => 
                    d.SurName.Contains(search) || 
                    d.FirstName.Contains(search) ||
                    d.Patronymic.Contains(search) || 
                    d.Position.Contains(search))
                .ToList();
        }
    }
} 