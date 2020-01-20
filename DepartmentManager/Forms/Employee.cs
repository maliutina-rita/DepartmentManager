using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DepartmentManager.Models;
using DepartmentManager.Repository;

namespace DepartmentManager.Forms
{
    public partial class Employee : Form
    {
        readonly EmployeeRepository employeeRepository = new EmployeeRepository();
        readonly DepartmentRepository departmentRepository = new DepartmentRepository();

        readonly private Action refreshTable;
        readonly private DbEmployee employee;
        readonly private string depName;

        public Employee(DbEmployee employee, Action refreshTable, string depName)
        {
            this.employee = employee;
            this.refreshTable = refreshTable;
            this.depName = depName;

            InitializeComponent();

            if (employee == null)
            {
                this.Text = "AddNewEmployee";
                EmployeeGroupBox.Text = "Добавить данные";
            }
            else
            {
                this.Text = "EditEmployee";
                EmployeeGroupBox.Text = "Редактировать данные";
            }

            DepartmentComboBox.DataSource = departmentRepository.GetAllDepartments();
            DepartmentComboBox.ValueMember = "ID";
            DepartmentComboBox.DisplayMember = "Name";

            LineLengthSetting();
            InitializeTextBox();

            DepartmentComboBox.SelectedIndex = DepartmentComboBox.FindStringExact(depName);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (employee == null)
                {
                    employeeRepository.AddEmployee(SurNameTextBox.Text, FirstNameTextBox.Text, PatronymicTextBox.Text, DateOfBirthTimePicker.Value,
                        DocSeriesTextBox.Text, DocNumberTextBox.Text, PositionTextBox.Text, (DbDepartment)DepartmentComboBox.SelectedItem);

                    refreshTable();
                    Close();
                }
                else
                {
                    employeeRepository.EditEmployee(employee.ID, SurNameTextBox.Text, FirstNameTextBox.Text, PatronymicTextBox.Text, DateOfBirthTimePicker.Value,
                       DocSeriesTextBox.Text, DocNumberTextBox.Text, PositionTextBox.Text, DepartmentComboBox.SelectedItem.ToString());

                    refreshTable();
                    Close();
                }
            } 
        }

        public void SurNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string namePattern = @"[а-я]";

            var surNameIsMatch = Regex.IsMatch(SurNameTextBox.Text, namePattern);

            if (String.IsNullOrEmpty(SurNameTextBox.Text))
            {
                e.Cancel = true;
                SurNameTextBox.Focus();
                ErrorProvider.SetError(SurNameTextBox, "Укажите фамилию");
            }
            else if (surNameIsMatch == false)
            {
                e.Cancel = true;
                SurNameTextBox.Focus();
                ErrorProvider.SetError(SurNameTextBox, "Недопустимый формат");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(SurNameTextBox, null);
            }           
        }

        private void FirstNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string namePattern = @"[а-я]";
            var firstNameIsMatch = Regex.IsMatch(FirstNameTextBox.Text, namePattern);

            if (String.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                e.Cancel = true;
                FirstNameTextBox.Focus();
                ErrorProvider.SetError(FirstNameTextBox, "Укажите имя");
            }
            else if (firstNameIsMatch == false)
            {
                e.Cancel = true;
                FirstNameTextBox.Focus();
                ErrorProvider.SetError(FirstNameTextBox, "Недопустимый формат");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(FirstNameTextBox, null);
            }           
        }

        private void PatronymicTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string namePattern = @"[а-я]";
            var patronymicIsMatch = Regex.IsMatch(PatronymicTextBox.Text, namePattern);

            if (patronymicIsMatch == false)
            {
                e.Cancel = true;
                PatronymicTextBox.Focus();
                ErrorProvider.SetError(PatronymicTextBox, "Недопустимый формат");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(PatronymicTextBox, null);
            }           
        }

        private void DateOfBirthTimePicker_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DateOfBirthTimePicker.Value > DateTime.Today)
            {
                ErrorProvider.SetError(DateOfBirthTimePicker, "Неверная дата");
            }
            else
            {
                ErrorProvider.Clear();
            }            
        }

        private void DocSeriesTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DocValidating(DocSeriesTextBox.Text, DocSeriesTextBox, ErrorProvider, e);           
        }

        private void DocNumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DocValidating(DocNumberTextBox.Text, DocNumberTextBox, ErrorProvider, e);            
        }

        private void PositionTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string namePattern = @"[а-я]";

            var positionIsMatch = Regex.IsMatch(PositionTextBox.Text, namePattern);

            if (String.IsNullOrEmpty(PositionTextBox.Text))
            {
                e.Cancel = true;
                PositionTextBox.Focus();
                ErrorProvider.SetError(PositionTextBox, "Укажите должность");
            }
            else if (positionIsMatch == false)
            {
                e.Cancel = true;
                PositionTextBox.Focus();
                ErrorProvider.SetError(PositionTextBox, "Неверный формат");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(PositionTextBox, null);
            }           
        }

        public void DocValidating(string docText, TextBox docTextBox, ErrorProvider error, System.ComponentModel.CancelEventArgs e)
        {
            string docPattern = @"\d";
            var docIsMatch = Regex.IsMatch(docText, docPattern);

            if (docIsMatch == false)
            {
                e.Cancel = true;
                docTextBox.Focus();
                error.SetError(docTextBox, "Неверный формат");
            }
            else
            {
                e.Cancel = false;
                error.SetError(docTextBox, null);
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
