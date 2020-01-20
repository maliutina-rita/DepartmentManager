using DepartmentManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DepartmentManager.Repository
{
    public class EmployeeRepository
    {
        Context context = new Context();

        public DbEmployee GetEmployee(decimal id)
        {
            var employee = context
                .DbEmployees
                .Include(i => i.Department)
                .FirstOrDefault(d => d.ID == id);

            if(employee != null)
            {
                return employee;
            }
            return null;
        }

        public List<DbEmployee> GetDepartmentEmployee(Guid departamentId)
        {
            var employees = context.DbEmployees.Where(e => e.DepartmentID == departamentId).ToList();

            return employees;
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

            if (patronymic != null)
            {
                employee.Patronymic = patronymic;
            }
            
            if(docSeries != null)
            {
                employee.DocSeries = docSeries;
            }

            if(docNumber != null)
            {
                employee.DocNumber = docNumber;
            }

            context.DbEmployees.Add(employee);
            context.SaveChanges();
        }

        public void EditEmployee(decimal id, string surName, string firstName, string patronymic, DateTime dateOfBirth,
            string docSeries, string docNumber, string position, string currentDepartment)
        {
            var employee = context.DbEmployees.FirstOrDefault(d => d.ID == id);

            if(employee != null)
            {
                employee.SurName = surName;
                employee.FirstName = firstName;
                employee.Patronymic = patronymic;
                employee.DateOfBirth = dateOfBirth;
                employee.DocSeries = docSeries;
                employee.DocNumber = docNumber;
                employee.Position = position;

                var department = context.DbDepartments.FirstOrDefault(d => d.Name == currentDepartment);

                if (department != null)
                {
                    employee.Department = department;
                }

                context.SaveChanges();
            }
        }

        public List<DbEmployee> SearchEmployee(string search)
        {
            var employee = context.DbEmployees.Where(d => d.SurName.Contains(search) || d.FirstName.Contains(search)||
            d.Patronymic.Contains(search) || d.Position.Contains(search)).ToList();

            return employee;
        }
    }
} 