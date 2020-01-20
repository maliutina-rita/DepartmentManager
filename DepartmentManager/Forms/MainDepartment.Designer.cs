namespace DepartmentManager
{
    partial class MainDepartment
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
            this.DepartemntsTree = new System.Windows.Forms.TreeView();
            this.MainDepartmentNameLabel = new System.Windows.Forms.Label();
            this.MainDepartmentCodeLabel = new System.Windows.Forms.Label();
            this.InformationGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.MainDepEmpTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.surNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InformationGroupBox.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDepEmpTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDepartmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DepartemntsTree
            // 
            this.DepartemntsTree.Location = new System.Drawing.Point(0, 0);
            this.DepartemntsTree.Name = "DepartemntsTree";
            this.DepartemntsTree.Size = new System.Drawing.Size(566, 228);
            this.DepartemntsTree.TabIndex = 6;
            this.DepartemntsTree.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DepartemntsTree_MouseDoubleClick);
            // 
            // MainDepartmentNameLabel
            // 
            this.MainDepartmentNameLabel.AutoSize = true;
            this.MainDepartmentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainDepartmentNameLabel.Location = new System.Drawing.Point(54, 29);
            this.MainDepartmentNameLabel.Name = "MainDepartmentNameLabel";
            this.MainDepartmentNameLabel.Size = new System.Drawing.Size(90, 13);
            this.MainDepartmentNameLabel.TabIndex = 7;
            this.MainDepartmentNameLabel.Text = "DepartmentName";
            // 
            // MainDepartmentCodeLabel
            // 
            this.MainDepartmentCodeLabel.AutoSize = true;
            this.MainDepartmentCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainDepartmentCodeLabel.Location = new System.Drawing.Point(54, 56);
            this.MainDepartmentCodeLabel.Name = "MainDepartmentCodeLabel";
            this.MainDepartmentCodeLabel.Size = new System.Drawing.Size(87, 13);
            this.MainDepartmentCodeLabel.TabIndex = 8;
            this.MainDepartmentCodeLabel.Text = "DepartmentCode";
            // 
            // InformationGroupBox
            // 
            this.InformationGroupBox.Controls.Add(this.label2);
            this.InformationGroupBox.Controls.Add(this.label1);
            this.InformationGroupBox.Controls.Add(this.MainDepartmentCodeLabel);
            this.InformationGroupBox.Controls.Add(this.MainDepartmentNameLabel);
            this.InformationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.InformationGroupBox.Name = "InformationGroupBox";
            this.InformationGroupBox.Size = new System.Drawing.Size(574, 100);
            this.InformationGroupBox.TabIndex = 9;
            this.InformationGroupBox.TabStop = false;
            this.InformationGroupBox.Text = "Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Controls.Add(this.tabPage2);
            this.MainTabControl.Location = new System.Drawing.Point(17, 141);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(574, 254);
            this.MainTabControl.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DepartemntsTree);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(566, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Departments";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SearchTextBox);
            this.tabPage2.Controls.Add(this.MainDepEmpTable);
            this.tabPage2.Controls.Add(this.SearchButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(566, 228);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employees";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(366, 8);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchTextBox.TabIndex = 12;
            this.SearchTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.SearchTextBox_Validating);
            // 
            // MainDepEmpTable
            // 
            this.MainDepEmpTable.AutoGenerateColumns = false;
            this.MainDepEmpTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDepEmpTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.Column1});
            this.MainDepEmpTable.DataSource = this.dbEmployeeBindingSource;
            this.MainDepEmpTable.Location = new System.Drawing.Point(2, 42);
            this.MainDepEmpTable.MultiSelect = false;
            this.MainDepEmpTable.Name = "MainDepEmpTable";
            this.MainDepEmpTable.ReadOnly = true;
            this.MainDepEmpTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainDepEmpTable.Size = new System.Drawing.Size(563, 186);
            this.MainDepEmpTable.TabIndex = 0;
            this.MainDepEmpTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDepEmpTable_CellClick);
            this.MainDepEmpTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDepEmpTable_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Edit";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(485, 6);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchErrorProvider
            // 
            this.SearchErrorProvider.ContainerControl = this;
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
            // dbDepartmentBindingSource
            // 
            this.dbDepartmentBindingSource.DataSource = typeof(DepartmentManager.Models.DbDepartment);
            // 
            // MainDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 420);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.InformationGroupBox);
            this.Name = "MainDepartment";
            this.Text = "MainDepartment";
            this.InformationGroupBox.ResumeLayout(false);
            this.InformationGroupBox.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDepEmpTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDepartmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dbEmployeeBindingSource;
        private System.Windows.Forms.BindingSource dbDepartmentBindingSource;
        private System.Windows.Forms.TreeView DepartemntsTree;
        private System.Windows.Forms.Label MainDepartmentNameLabel;
        private System.Windows.Forms.Label MainDepartmentCodeLabel;
        private System.Windows.Forms.GroupBox InformationGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView MainDepEmpTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ErrorProvider SearchErrorProvider;
    }
}