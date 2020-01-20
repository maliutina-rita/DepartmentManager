using DepartmentManager.Forms;
using DepartmentManager.Models;
using DepartmentManager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DepartmentManager
{
    public partial class MainDepartment : Form
    {
        DepartmentRepository departmentRepository = new DepartmentRepository();
        EmployeeRepository employeeRepository = new EmployeeRepository();

        public MainDepartment()
        {
            InitializeComponent();
            InitializeDepartmentTree();
        }

        private void InitializeDepartmentTree()
        {
            var mainDepartment = departmentRepository
                .GetAllDepartments()
                .FirstOrDefault(p => p.ParentDepartmentID == null);

            MainDepartmentNameLabel.Text = mainDepartment.Name;
            MainDepartmentCodeLabel.Text = mainDepartment.Code;

            MainDepEmpTable.DataSource = employeeRepository.GetDepartmentEmployee(mainDepartment.ID);

            foreach (var department in mainDepartment.SubDepartments)
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

                var form = new Employee(employee, RefreshMainDepartmentEmployee);
                form.Show();
            }
        }

        private void MainDepEmpTable_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var emloyee = (DbEmployee)MainDepEmpTable.CurrentRow.DataBoundItem;

            var form = new EmployeeInfoForm(emloyee.ID);
            form.Show();
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
    }
}
