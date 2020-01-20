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

        private bool IsValidForm = false;  

        public Employee(DbEmployee employee, Action refreshTable, string depName)
        {
            this.employee = employee;
            this.refreshTable = refreshTable;
            this.depName = depName;

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

            DepartmentComboBox.DataSource = departmentRepository.GetAllDepartments();
            DepartmentComboBox.ValueMember = "ID";
            DepartmentComboBox.DisplayMember = "Name";

            LineLengthSetting();
            InitializeTextBox();

            DepartmentComboBox.SelectedIndex = DepartmentComboBox.FindStringExact(depName);

          //  SaveButton.Enabled = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(SurNameTextBox.Text, "Messeg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(FirstNameTextBox.Text, "Messeg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(PatronymicTextBox.Text, "Messeg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(PositionTextBox.Text, "Messeg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            if (employee == null)
            {
                employeeRepository.AddEmployee(SurNameTextBox.Text, FirstNameTextBox.Text, PatronymicTextBox.Text, DateOfBirthTimePicker.Value,
                    DocSeriesTextBox.Text, DocNumberTextBox.Text, PositionTextBox.Text, (DbDepartment) DepartmentComboBox.SelectedItem);

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

        private void SurNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string namePattern = @"[а-я]";

            var surNameIsMatch = Regex.IsMatch(SurNameTextBox.Text, namePattern);

            if (String.IsNullOrEmpty(SurNameTextBox.Text))
            {
                e.Cancel = true;
                SurNameTextBox.Focus();
                SurNameErrorProvider.SetError(SurNameTextBox, "Укажите фамилию");
            }
            else if (surNameIsMatch == false)
            {
                e.Cancel = true;
                SurNameTextBox.Focus();
                SurNameErrorProvider.SetError(SurNameTextBox, "Недопустимый формат");
            }
            else
            {
                e.Cancel = false;
                SurNameErrorProvider.SetError(SurNameTextBox, null);
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
                FirstNameErrorProvider.SetError(FirstNameTextBox, "Укажите имя");
            }
            else if (firstNameIsMatch == false)
            {
                e.Cancel = true;
                FirstNameTextBox.Focus();
                FirstNameErrorProvider.SetError(FirstNameTextBox, "Недопустимый формат");
            }
            else
            {
                e.Cancel = false;
                FirstNameErrorProvider.SetError(FirstNameTextBox, null);
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
                PatronymicErrorProvider.SetError(PatronymicTextBox, "Недопустимый формат");
            }
            else
            {
                e.Cancel = false;
                PatronymicErrorProvider.SetError(FirstNameTextBox, null);
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
            //DocValidating(DocSeriesTextBox.Text, DocSeriesTextBox, DocSeriesErrorProvider);           
        }

        private void DocNumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //DocValidating(DocNumberTextBox.Text, DocNumberTextBox, DocNumberErrorProvider);            
        }

        private void PositionTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string namePattern = @"[а-я]";

            var positionIsMatch = Regex.IsMatch(PositionTextBox.Text, namePattern);

            if (String.IsNullOrEmpty(PositionTextBox.Text))
            {
                e.Cancel = true;
                PositionTextBox.Focus();
                PositionErrorProvider.SetError(PositionTextBox, "Укажите должность");
            }
            else if (positionIsMatch == false)
            {
                e.Cancel = true;
                PositionTextBox.Focus();
                PositionErrorProvider.SetError(PositionTextBox, "Неверный формат");
            }
            else
            {
                e.Cancel = false;
                PositionErrorProvider.SetError(PositionTextBox, null);
            }           
        }

        public void DocValidating(string docText, TextBox docTextBox, ErrorProvider error)
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

        public void UpdateValidForm()
        {
            //SaveButton.Enabled =
            //    IsValid(SurNameErrorProvider) &&
            //    IsValid(FirstNameErrorProvider) &&
            //    IsValid(PatronymicErrorProvider) &&
            //    IsValid(DocSeriesErrorProvider) &&
            //    IsValid(DocNumberErrorProvider) &&
            //    IsValid(PositionErrorProvider);

             

            //var a1 = IsValid(SurNameErrorProvider);
            //var a2 = IsValid(FirstNameErrorProvider);
            //var a3 = IsValid(PatronymicErrorProvider);
            //var a4 = IsValid(DocSeriesErrorProvider);
            //var a5 = IsValid(DocNumberErrorProvider);
            //var a6 = IsValid(PositionErrorProvider);
        }

        //private bool IsValid(ErrorProvider errorProvider)
        //{
        //    foreach (Control c in errorProvider.ContainerControl.Controls)
        //    {
        //        var error = errorProvider.GetError(c);
        //        if (error != "")
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

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
