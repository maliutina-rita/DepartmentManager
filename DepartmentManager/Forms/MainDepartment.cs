using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DepartmentManager.Forms;
using DepartmentManager.Models;
using DepartmentManager.Repository;

namespace DepartmentManager
{
    public partial class MainDepartment : Form
    {
        readonly DepartmentRepository departmentRepository = new DepartmentRepository();
        readonly EmployeeRepository employeeRepository = new EmployeeRepository();
        private DbDepartment department;

        public MainDepartment()
        {
            InitializeComponent();
            InitializeDepartmentTree();
        }

        private void InitializeDepartmentTree()
        {
            department = departmentRepository
                .GetAllDepartments()
                .FirstOrDefault(p => p.ParentDepartmentID == null);

            MainDepartmentNameLabel.Text = department.Name;
            MainDepartmentCodeLabel.Text = department.Code;

            MainDepEmpTable.DataSource = employeeRepository.GetDepartmentEmployee(department.ID);

            foreach (var department in department.SubDepartments)
            {
                var nodes = DepartemntsTree.Nodes.Add(department.ID.ToString(), department.Name);
                if (department.SubDepartments.Any())
                {
                    AddNodes(department.SubDepartments.ToList(), nodes);
                }
            }
        }

        public void AddNodes(List<DbDepartment> departments, TreeNode node)
        {
            foreach (var department in departments)
            {
                var nodes = node.Nodes.Add(department.ID.ToString(), department.Name);
                var subDepartments = department.SubDepartments.ToList();

                if (subDepartments.Any())
                {
                    AddNodes(subDepartments, nodes);
                }
            }
        }

        public void RefreshMainDepartmentEmployee()
        {
            var mainDepartment = departmentRepository
                .GetAllDepartments()
                .FirstOrDefault(p => p.ParentDepartmentID == null);
            
            MainDepEmpTable.DataSource = employeeRepository.GetDepartmentEmployee(mainDepartment.ID);
        }

        private void DepartemntsTree_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = new Guid(DepartemntsTree.SelectedNode.Name);
            var form = new Department(id);
            form.Show();
        }

        private void MainDepEmpTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var employee = (DbEmployee)MainDepEmpTable.CurrentRow.DataBoundItem;

                var form = new Employee(employee, RefreshMainDepartmentEmployee, department.Name);
                form.Show();
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            MainDepEmpTable.DataSource = employeeRepository.SearchEmployee(SearchTextBox.Text);
        }

        private void SearchTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string namePattern = @"[а-я]";
            var patronymicIsMatch = Regex.IsMatch(SearchTextBox.Text, namePattern);

            if (patronymicIsMatch == false)
            {
                SearchErrorProvider.SetError(SearchTextBox, "Недопустимый формат");
            }
        }

        private void MainDepEmpTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var emloyee = (DbEmployee)MainDepEmpTable.CurrentRow.DataBoundItem;

            var form = new EmployeeInfoForm(emloyee.ID);
            form.Show();
        }
    }
}
