﻿using DepartmentManager.Repository;
using System;
using System.Windows.Forms;

namespace DepartmentManager.Forms
{
    public partial class EmployeeInfoForm : Form
    {
        EmployeeRepository repository = new EmployeeRepository();

        decimal id;

        public EmployeeInfoForm(decimal id)
        {
            this.id = id;

            InitializeComponent();

            ShowEmloyeeInfo();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ShowEmloyeeInfo()
        {
            var employee = repository.GetEmployee(id);

            var date = CalculateAge(employee.DateOfBirth);

            if (employee != null)
            {
                SurNameText.Text = employee.SurName;
                FirstNameText.Text = employee.FirstName;
                PatronymicText.Text = employee.Patronymic;
                DocSeriesText.Text = employee.DocSeries;
                DocNumberText.Text = employee.DocNumber;
                PositionText.Text = employee.Position;
                DepartmentText.Text = employee.Department.Name;
                AgeText.Text = date.ToString();
            }
        }

        public int CalculateAge(DateTime timeOfBirth)
        {
            int years = DateTime.Now.Year - timeOfBirth.Year;

            if(DateTime.Now.Month< timeOfBirth.Month || (DateTime.Now.Month == timeOfBirth.Month && DateTime.Now.Day < timeOfBirth.Day))
            {
                years--;
            }
            return years;
        }
    }
}
