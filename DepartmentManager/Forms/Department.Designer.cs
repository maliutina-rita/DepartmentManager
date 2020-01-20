namespace DepartmentManager.Forms
{
    partial class Department
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.NameTextLabel = new System.Windows.Forms.Label();
            this.CodeTextLabel = new System.Windows.Forms.Label();
            this.AddEmloyeeButton = new System.Windows.Forms.Button();
            this.InformationGroupBox = new System.Windows.Forms.GroupBox();
            this.SubDepartmentTreeView = new System.Windows.Forms.TreeView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.EmloyeesGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EmployeesTable = new System.Windows.Forms.DataGridView();
            this.surNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InformationGroupBox.SuspendLayout();
            this.EmloyeesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 52);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(41, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name :";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(6, 28);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(38, 13);
            this.CodeLabel.TabIndex = 1;
            this.CodeLabel.Text = "Code :";
            // 
            // NameTextLabel
            // 
            this.NameTextLabel.AutoSize = true;
            this.NameTextLabel.Location = new System.Drawing.Point(51, 52);
            this.NameTextLabel.Name = "NameTextLabel";
            this.NameTextLabel.Size = new System.Drawing.Size(16, 13);
            this.NameTextLabel.TabIndex = 9;
            this.NameTextLabel.Text = "...";
            // 
            // CodeTextLabel
            // 
            this.CodeTextLabel.AutoSize = true;
            this.CodeTextLabel.Location = new System.Drawing.Point(51, 28);
            this.CodeTextLabel.Name = "CodeTextLabel";
            this.CodeTextLabel.Size = new System.Drawing.Size(16, 13);
            this.CodeTextLabel.TabIndex = 10;
            this.CodeTextLabel.Text = "...";
            // 
            // AddEmloyeeButton
            // 
            this.AddEmloyeeButton.Location = new System.Drawing.Point(451, 24);
            this.AddEmloyeeButton.Name = "AddEmloyeeButton";
            this.AddEmloyeeButton.Size = new System.Drawing.Size(129, 23);
            this.AddEmloyeeButton.TabIndex = 12;
            this.AddEmloyeeButton.Text = "Add emloyee";
            this.AddEmloyeeButton.UseVisualStyleBackColor = true;
            this.AddEmloyeeButton.Click += new System.EventHandler(this.AddEmloyeeButton_Click);
            // 
            // InformationGroupBox
            // 
            this.InformationGroupBox.Controls.Add(this.SubDepartmentTreeView);
            this.InformationGroupBox.Controls.Add(this.CodeTextLabel);
            this.InformationGroupBox.Controls.Add(this.NameLabel);
            this.InformationGroupBox.Controls.Add(this.CodeLabel);
            this.InformationGroupBox.Controls.Add(this.NameTextLabel);
            this.InformationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.InformationGroupBox.Name = "InformationGroupBox";
            this.InformationGroupBox.Size = new System.Drawing.Size(606, 239);
            this.InformationGroupBox.TabIndex = 13;
            this.InformationGroupBox.TabStop = false;
            this.InformationGroupBox.Text = "Information";
            // 
            // SubDepartmentTreeView
            // 
            this.SubDepartmentTreeView.Location = new System.Drawing.Point(257, 19);
            this.SubDepartmentTreeView.Name = "SubDepartmentTreeView";
            this.SubDepartmentTreeView.Size = new System.Drawing.Size(323, 138);
            this.SubDepartmentTreeView.TabIndex = 11;
            this.SubDepartmentTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SubDepartmentTreeView_AfterSelect);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(338, 24);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(194, 26);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(126, 20);
            this.SearchTextBox.TabIndex = 14;
            this.SearchTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.SearchTextBox_Validating);
            // 
            // EmloyeesGroupBox
            // 
            this.EmloyeesGroupBox.Controls.Add(this.EmployeesTable);
            this.EmloyeesGroupBox.Controls.Add(this.SearchButton);
            this.EmloyeesGroupBox.Controls.Add(this.AddEmloyeeButton);
            this.EmloyeesGroupBox.Controls.Add(this.SearchTextBox);
            this.EmloyeesGroupBox.Location = new System.Drawing.Point(12, 269);
            this.EmloyeesGroupBox.Name = "EmloyeesGroupBox";
            this.EmloyeesGroupBox.Size = new System.Drawing.Size(641, 302);
            this.EmloyeesGroupBox.TabIndex = 17;
            this.EmloyeesGroupBox.TabStop = false;
            this.EmloyeesGroupBox.Text = "Emloyees";
            // 
            // SearchErrorProvider
            // 
            this.SearchErrorProvider.ContainerControl = this;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Edit";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // EmployeesTable
            // 
            this.EmployeesTable.AutoGenerateColumns = false;
            this.EmployeesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.Column1});
            this.EmployeesTable.DataSource = this.dbEmployeeBindingSource;
            this.EmployeesTable.Location = new System.Drawing.Point(35, 53);
            this.EmployeesTable.MultiSelect = false;
            this.EmployeesTable.Name = "EmployeesTable";
            this.EmployeesTable.ReadOnly = true;
            this.EmployeesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeesTable.Size = new System.Drawing.Size(545, 226);
            this.EmployeesTable.TabIndex = 4;
            this.EmployeesTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeesTable_CellClick);
            this.EmployeesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeesTable_CellContentClick);
            // 
            // surNameDataGridViewTextBoxColumn
            // 
            this.surNameDataGridViewTextBoxColumn.DataPropertyName = "SurName";
            this.surNameDataGridViewTextBoxColumn.HeaderText = "SurName";
            this.surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
            this.surNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbEmployeeBindingSource
            // 
            this.dbEmployeeBindingSource.DataSource = typeof(DepartmentManager.Models.DbEmployee);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 609);
            this.Controls.Add(this.EmloyeesGroupBox);
            this.Controls.Add(this.InformationGroupBox);
            this.Name = "Department";
            this.Text = "Department";
            this.InformationGroupBox.ResumeLayout(false);
            this.InformationGroupBox.PerformLayout();
            this.EmloyeesGroupBox.ResumeLayout(false);
            this.EmloyeesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmployeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label NameTextLabel;
        private System.Windows.Forms.Label CodeTextLabel;
        private System.Windows.Forms.BindingSource dbEmployeeBindingSource;
        private System.Windows.Forms.Button AddEmloyeeButton;
        private System.Windows.Forms.GroupBox InformationGroupBox;
        private System.Windows.Forms.TreeView SubDepartmentTreeView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.GroupBox EmloyeesGroupBox;
        private System.Windows.Forms.ErrorProvider SearchErrorProvider;
        private System.Windows.Forms.DataGridView EmployeesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}