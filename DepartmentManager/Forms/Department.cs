using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DepartmentManager.Models;
using DepartmentManager.Repository;

namespace DepartmentManager.Forms
{
    public partial class Department : Form
    {
        readonly private Guid id;
        readonly private DbDepartment department;

        readonly DepartmentRepository departmentRepository = new DepartmentRepository();
        readonly EmployeeRepository employeeRepository = new EmployeeRepository();

        public Department(Guid id)
        {
            this.id = id;

            InitializeComponent();
            InitializeDepartmentTree();

            department = departmentRepository.GetDepartment(id);

            NameTextLabel.Text = department.Name;
            CodeTextLabel.Text = department.Code;
            EmployeesTable.DataSource = employeeRepository.GetDepartmentEmployee(id);
        }

        private void InitializeDepartmentTree()
        {
            var mainDepartment = departmentRepository
                .GetAllDepartments()
                .FirstOrDefault(p => p.ID == id);

            if(mainDepartment != null)
            {
                foreach (var department in mainDepartment.SubDepartments)
                {
                    var nodes = SubDepartmentTreeView.Nodes.Add(department.ID.ToString(), department.Name);

                    if (department.SubDepartments.Any())
                    {
                        AddNodes(department.SubDepartments.ToList(), nodes);
                    }
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

        private void EmployeesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {

                var employee= (DbEmployee)EmployeesTable.CurrentRow.DataBoundItem;

                var form = new Employee(employee, RefreshParentTableEmployee, department.Name);
                form.Show();
            }
        }

        private void AddEmloyeeButton_Click(object sender, EventArgs e)
        {
            var form = new Employee(null, RefreshParentTableEmployee, department.Name);
            form.Show();
        }

        private void SubDepartmentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var id = new Guid(SubDepartmentTreeView.SelectedNode.Name);
            EmployeesTable.DataSource = employeeRepository.GetDepartmentEmployee(id);
        }

        public void RefreshParentTableEmployee()
        {
            EmployeesTable.DataSource = employeeRepository.GetDepartmentEmployee(id);
        }

        public string GetDepartmentName()
        {
            return NameTextLabel.Text;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            EmployeesTable.DataSource = employeeRepository.SearchEmployee(SearchTextBox.Text);
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

        private void EmployeesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var emloyee = (DbEmployee)EmployeesTable.CurrentRow.DataBoundItem;

            var form = new EmployeeInfoForm(emloyee.ID);
            form.Show();
        }
    }
}
