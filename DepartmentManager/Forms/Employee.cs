using DepartmentManager.Models;
using DepartmentManager.Repository;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DepartmentManager.Forms
{
    public partial class Employee : Form
    {
        EmployeeRepository empRepository = new EmployeeRepository();
        DepartmentRepository depRepository = new DepartmentRepository();

        Action refreshTable;

        DbEmployee employee;
        public Employee(DbEmployee employee, Action refreshTable)
        {
            this.employee = employee;
            this.refreshTable = refreshTable;

            InitializeComponent();


            if (employee == null)
            {
                this.Text = "AddNewEmployee";
                EmployeeGroupBox.Text = "Add new employee";
            }
            else
            {
                this.Text = "EditEmployee";
                EmployeeGroupBox.Text = "Edit employee";
            }

            DepartmentComboBox.DataSource = depRepository.GetAllDepartments();
            DepartmentComboBox.ValueMember = "ID";
            DepartmentComboBox.DisplayMember = "Name";

            LineLengthSetting();
            InitializeTextBox();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (employee == null)
            {
                empRepository.AddEmployee(SurNameTextBox.Text, FirstNameTextBox.Text, PatronymicTextBox.Text, DateOfBirthTimePicker.Value,
                    DocSeriesTextBox.Text, DocNumberTextBox.Text, PositionTextBox.Text, (DbDepartment)DepartmentComboBox.SelectedItem);

                refreshTable();
                Close();              
            }            
            else
            {
                empRepository.EditEmployee(employee.ID, SurNameTextBox.Text, FirstNameTextBox.Text, PatronymicTextBox.Text, DateOfBirthTimePicker.Value,
                   DocSeriesTextBox.Text, DocNumberTextBox.Text, PositionTextBox.Text, DepartmentComboBox.SelectedItem.ToString());

                refreshTable();
                Close();
            }
        }

        private void SurNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string namePattern = @"[а-я]";

            var surNameIsMatch = Regex.IsMatch(SurNameTextBox.Text, namePattern);

            if (String.IsNullOrEmpty(SurNameTextBox.Text))
            {
                SurNameErrorProvider.SetError(SurNameTextBox, "Укажите фамилию");
            }
            else if (surNameIsMatch == false)
            {
                SurNameErrorProvider.SetError(SurNameTextBox, "Недопустимый формат");
            }
            else
            {
                SurNameErrorProvider.Clear();
            }
        }

        private void FirstNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string namePattern = @"[а-я]";
            var firstNameIsMatch = Regex.IsMatch(FirstNameTextBox.Text, namePattern);

            if (String.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                FirstNameErrorProvider.SetError(FirstNameTextBox, "Укажите имя");
            }
            else if (firstNameIsMatch == false)
            {
                FirstNameErrorProvider.SetError(FirstNameTextBox, "Недопустимый формат");
            }
            else
            {
                FirstNameErrorProvider.Clear();
            }
        }

        private void PatronymicTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string namePattern = @"[а-я]";
            var patronymicIsMatch = Regex.IsMatch(PatronymicTextBox.Text, namePattern);
            if (patronymicIsMatch == false)
            {
                PatronymicErrorProvider.SetError(PatronymicTextBox, "Недопустимый формат");
            }
            else
            {
                PatronymicErrorProvider.Clear();
            }
        }

        private void DateOfBirthTimePicker_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DateOfBirthTimePicker.Value > DateTime.Today)
            {
                DateErrorProvider.SetError(DateOfBirthTimePicker, "Неверная дата");
            }
            else
            {
                DateErrorProvider.Clear();
            }
        }

        private void DocSeriesTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DocValidating(DocSeriesTextBox.Text, DocSeriesTextBox, DocSeriesErrorProvider);
        }

        private void DocNumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DocValidating(DocNumberTextBox.Text, DocNumberTextBox, DocNumberErrorProvider);
        }

        private void PositionTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string namePattern = @"[а-я]";

            var positionIsMatch = Regex.IsMatch(PositionTextBox.Text, namePattern);

            if (String.IsNullOrEmpty(PositionTextBox.Text))
            {
                PositionErrorProvider.SetError(PositionTextBox, "Укажите должность");
            }
            else if (positionIsMatch == false)
            {
                PositionErrorProvider.SetError(PositionTextBox, "Неверный формат");
            }
            else
            {
                PositionErrorProvider.Clear();
            }
        }

        public void DocValidating(string docText,TextBox docTextBox, ErrorProvider error)
        {
            string docPattern = @"\d";
            var docIsMatch = Regex.IsMatch(docText, docPattern);
            if (docIsMatch == false)
            {
                error.SetError(docTextBox, "Неверный формат");
            }
            else
            {
                error.Clear();
            }
        }

        public void LineLengthSetting()
        {
            SurNameTextBox.MaxLength = 50;
            FirstNameTextBox.MaxLength = 50;
            PatronymicTextBox.MaxLength = 50;
            DocSeriesTextBox.MaxLength = 4;
            DocNumberTextBox.MaxLength = 6;
            PositionTextBox.MaxLength = 50;
            DateOfBirthTimePicker.MaxDate = DateTime.Today;
        }

        public void InitializeTextBox()
        {
            SurNameTextBox.Text = employee?.SurName ?? string.Empty;
            FirstNameTextBox.Text = employee?.FirstName ?? string.Empty;
            PatronymicTextBox.Text = employee?.Patronymic ?? string.Empty;
            DocSeriesTextBox.Text = employee?.DocSeries ?? string.Empty;
            DocNumberTextBox.Text = employee?.DocNumber ?? string.Empty;
            PositionTextBox.Text = employee?.Position ?? string.Empty;
        }
    }
}
